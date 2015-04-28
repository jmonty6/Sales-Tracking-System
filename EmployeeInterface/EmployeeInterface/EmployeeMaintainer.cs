using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmployeeInterface
{
	class EmployeeMaintainer
	{
		MySqlConnection connection;
		SalesPerson employee;
		List<SalesPerson> empList = new List<SalesPerson>();

		public EmployeeMaintainer()
		{
			//connection string and connect to the db
			string strConn = "port=3306;server=50.165.81.108;user id=Kevin;password=ak4iulgjMwAShNX9rWsp;database=salestracking;";
			connection = new MySqlConnection(strConn);
		}

		public List<SalesPerson> searchById(int id)
		{
			string query = "SELECT s.name, s.commission, s.sid, s.address, e.password FROM employees e, salesperson s WHERE s.sid ='" + id + "' AND e.sid='" + id + "'";

			if (this.connect())
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					empList.Add(new SalesPerson(dr["name"] + "", dr.GetInt32(2), dr["password"] + "", dr.GetInt32(1), dr["address"] + ""));
				}
			}

			this.stopConnection();

			return empList;
		}

		public List<SalesPerson> searchByName(string name)
		{
			string query = "SELECT s.name, s.commission, s.sid, s.address, e.password FROM employees e, salesperson s WHERE s.name='" + name + "' AND s.sid=e.sid";

			if (this.connect())
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					if ((dr["name"] + "").Contains(name))
						empList.Add(new SalesPerson(dr["name"] + "", dr.GetInt32(2), dr["password"] + "", dr.GetInt32(1), dr["address"] + ""));
				}
			}

			this.stopConnection();

			return empList;
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

		public SalesPerson getCurrentSalesPerson()
		{
			return employee;
		}

		public void selectSalesPerson(SalesPerson sp)
		{
			employee = sp;
		}

		public void deleteSalesPerson(SalesPerson sp)
		{
			string query = "DELETE FROM salesperson WHERE sid='" + sp.getId() + "'";

			if (this.connect())
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				query = "DELETE FROM employees WHERE sid='" + sp.getId() + "'";
				cmd.CommandText = query;
				cmd.ExecuteNonQuery();
			}

			this.stopConnection();
		}

		public void addSalesPerson(SalesPerson sp)
		{
			string query = "INSERT INTO employees (id,password,sid) VALUES ('" + sp.getId() + "','" + sp.getPassword() + "','" + sp.getId() + "')";

			if (this.connect())
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				query = "INSERT INTO salesperson (sid,name,commission,address) VALUES ('" + sp.getId() + "','" + sp.getName() + "','" + sp.getCommission() + "','" + sp.getAddress() + "')";
				cmd.CommandText = query;
				cmd.ExecuteNonQuery();
			}

			this.stopConnection();
		}

		public void updateSalesPerson(SalesPerson sp)
		{
			string query = "UPDATE salesperson SET name='" + sp.getName() + "',commission='" + sp.getCommission() + "',address='" + sp.getAddress() + "' WHERE sid='" + sp.getId() + "'";

			if (this.connect())
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				query = "UPDATE employees SET id='" + sp.getId() + "',sid='" + sp.getId() + "',password='" + sp.getPassword() + "' WHERE sid='" + sp.getId() + "'";
				cmd.CommandText = query;
				cmd.ExecuteNonQuery();
			}

			this.stopConnection();
		}
	}
}
