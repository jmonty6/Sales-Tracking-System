using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInterface
{
	class SalesPerson
	{
		private string name;
		private int id;
		private string password;
		private int commission;
		private string address;

		public SalesPerson()
		{

		}

		public SalesPerson(string nm, int nid, string pw, int comm, string add)
		{
			name = nm;
			id = nid;
			password = pw;
			commission = comm;
			address = add;
		}

		public string getName()
		{
			return name;
		}

		public int getId()
		{
			return id;
		}

		public string getPassword()
		{
			return password;
		}

		public int getCommission()
		{
			return commission;
		}

		public string getAddress()
		{
			return address;
		}

		public void setName(string nm)
		{
			name = nm;
		}

		public void setId(int idd)
		{
			id = idd;
		}

		public void setPassword(string pw)
		{
			password = pw;
		}

		public void setCommission(int comm)
		{
			commission = comm;
		}

		public void setAddress(string add)
		{
			address = add;
		}
	}
}
