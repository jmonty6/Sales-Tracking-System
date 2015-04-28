using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace EmployeeInterface
{
    class QuoteConverter
    {
        Quote activeQuote;
        private MySqlConnection connection;

        public QuoteConverter()
        {
            
        }

        public void selectQuote(Quote quote)
        {
            activeQuote = quote;
        }

        public Quote getActiveQuote()
        {
            return activeQuote;
        }

        public string convertQuote(float discount)
        {
            // send datagram to processing system

            UdpClient client = new UdpClient("blitz.cs.niu.edu", 4446);

            string send_msg = activeQuote.getId() + ":" + activeQuote.getCustName() + ":" + (activeQuote.getTotalPrice() - discount);
            byte[] send_buffer = Encoding.ASCII.GetBytes(send_msg);

            client.Send(send_buffer, send_buffer.Length);

            // receive response from processing system

            string recv_msg;

            string hostname = "blitz.cs.niu.edu";

            IPHostEntry hostEntry = Dns.GetHostEntry(hostname);
            IPAddress serverAddress = hostEntry.AddressList[0];
            IPEndPoint endPoint = new IPEndPoint(serverAddress, 4446);

            byte[] recv_buffer = client.Receive(ref endPoint);
            recv_msg = Encoding.ASCII.GetString(recv_buffer);

            return recv_msg;
        }

        public void submitQuote()
        {

        }

        private bool connect()
		{
			try
			{
				connection.Open();
				return true;
			}
			//bullshit exceptions
			catch (MySqlException ex)
			{

				return false;
			}
		}

        private void stopConnection()
		{
			connection.Close();
		}
    }
}
