using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EmployeeInterface
{
    class quoteDB
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        // Constructor
        public quoteDB()
        {
            Initialize();
        }

        // Initialize values for connection to database
        private void Initialize()
        {
            // assign values to connection variables

            server = "50.165.81.10";
            database = "salestracking";
            user = "Kevin";
            password = "ak4iulgjMwAShNX9rWsp";
            
            // assemble string for connecting to database

            string connectionString = "SERVER=" + server + ";" +"DATABASE=" + database + ";"
                + "UID=" + user + ";" + "PASSWORD=" + password + ";";

            // create instance of MySqlConnection using connection string

            connection = new MySqlConnection(connectionString);
        }

        // Open connection to database
        private bool openConnection()
        {
            // if the connection opens successfully, return true

            try
            {
                connection.Open();

                return true;
            }

            // if an exception is returned, print an appropriate error message
            // and return false

            catch(MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server was unsuccessful.");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username or password. Please try again.");
                        break;
                }

                return false;
            }
        }

        // Close connection to database
        private bool closeConnection()
        {
            // if the connection closes successfully, return true

            try
            {
                connection.Close();

                return true;
            }
            
            // if an exception is returned, print its error message
            // and return false

            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        public void insert(string tableName, List<string> values)
        {
            string query = "INSERT INTO " + tableName + " VALUES(";



            if(this.openConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                this.closeConnection();
            }

        }

        public void update()
        {

        }

        public void delete()
        {

        }

        // not void
        public void select()
        {
            
        }

        public int count()
        {

            return 0;
        }

        public void backup()
        {

        }

        public void restore()
        {

        }
    }
}
