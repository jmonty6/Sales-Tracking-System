using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EmployeeInterface
{
    class QuoteSanctioner
    {
		private MySqlConnection connection;

		//constructor for initialization
		public QuoteSanctioner()
		{
			//connection string and connect to the db
			string strConn = "port=3306;server=50.165.81.108;user id=Kevin;password=ak4iulgjMwAShNX9rWsp;database=salestracking;";
			connection = new MySqlConnection(strConn);
		}

        public List<Quote> searchCustomer(string name)
        {
			//quote list for searched customer
			List<Quote> quotes = new List<Quote>();

			//query
			string query = "SELECT custName FROM quote";
			bool found = false;
			int i = 0;

			//list for results
			List<string> rs = new List<string>();

			//connect to the db and retrieve the data
			if (this.connect())
			{
				//execute the query
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					if ((dr["custName"] + "").Contains(name))
					{
						quotes.Add(new Quote(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7)));
					}
				}
			}
			this.stopConnection();

			return quotes;
        }

		public void searchQuote()
        {
            
        }

		public void selectQuote()
        {
            
        }

		public void submitQuote(string[] itemList, int[] priceList, string quoteName, string email, string salesPersonName, int discount, bool sanctioned)
        {

        }

		//function: bool connect()
		//purpose:  opens a connection to the employee database in order to validate credentials
		//returns:  true if connection works, false if connection fails
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

		//function: bool stopConnection()
		//purpose:  stops the connection to the database
		//returns:  true if disconnection succeeds
		private void stopConnection()
		{
			connection.Close();
		}
    }
}
