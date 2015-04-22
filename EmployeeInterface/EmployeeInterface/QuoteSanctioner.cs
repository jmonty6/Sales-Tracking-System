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
		private List<Quote> quoteList = new List<Quote>();
		private Quote activeQuote;

		//constructor for initialization
		public QuoteSanctioner()
		{
			//connection string and connect to the db
			string strConn = "port=3306;server=50.165.81.108;user id=Kevin;password=ak4iulgjMwAShNX9rWsp;database=salestracking;";
			connection = new MySqlConnection(strConn);
		}

        public List<Quote> searchCustomer(string name)
        {
			getAllQuotes(name);

			return quoteList;
        }

		public List<Quote> searchQuote(string name)
        {
			getAllQuoteNames(name);

			return quoteList;
        }

		public void selectQuote(Quote quote)
        {
			activeQuote = quote;
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

		//Function: void getAllQuotes(name)
		//Purpose:  retrieves all of the quotes from the db via customer name
		private void getAllQuotes(string name)
		{
			//query
			string query = "SELECT * FROM quote";

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
					//create new quotes using the data read
					if ((dr["custName"] + "").Contains(name))
						quoteList.Add(new Quote(dr.GetInt32(0), dr["name"] + "", dr["custName"] + "", dr["email"] + "", dr.GetInt32(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7)));
				}
				dr.Close();
			}
			this.stopConnection();
		}

		//Function: void getAllQuoteNames(name)
		//Purpose:  retrieves all of the quotes from the db via quote name
		private void getAllQuoteNames(string name)
		{
			//query
			string query = "SELECT * FROM quote";

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
					//create new quotes using the data read
					if ((dr["name"] + "").Contains(name))
						quoteList.Add(new Quote(dr.GetInt32(0), dr["name"] + "", dr["custName"] + "", dr["email"] + "", dr.GetInt32(4), dr.GetInt32(5), dr.GetInt32(6), dr.GetInt32(7)));
				}
				dr.Close();
			}
			this.stopConnection();
		}
    }
}
