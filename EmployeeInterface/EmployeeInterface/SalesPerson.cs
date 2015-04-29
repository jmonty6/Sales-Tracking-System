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
		private float commission;
		private string address;
		private int empId;

		public SalesPerson()
		{

		}

		public SalesPerson(string nm, int nid, string pw, float comm, string add)
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

		public float getCommission()
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

		public void setCommission(float comm)
		{
			commission = comm;
		}

		public void setAddress(string add)
		{
			address = add;
		}

		public void setEmpId(int idd)
		{
			empId = idd;
		}

		public int getEmpId()
		{
			return empId;
		}
	}
}
