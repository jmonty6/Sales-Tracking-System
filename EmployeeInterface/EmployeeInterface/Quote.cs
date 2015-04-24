using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInterface
{
    class Quote
    {
		private int quoteId;
        private string quoteName;
        private string email;
		private string salesPersonName;
        private int salesPersonId;
        private int discount;
        private int totalPrice;
        private bool sanctioned;
        private string customerName;

        private List<string> noteList;
        private List<Item> itemList;

		public Quote(int id, string qName, string custName, string em, int sId, int disc, int tPrice, int sanct)
		{
			quoteId = id;
			quoteName = qName;
			email = em;
			salesPersonId = sId;
			discount = disc;
			totalPrice = tPrice;
			if (sanct == 1)
				sanctioned = true;
			else
				sanctioned = false;
			customerName = custName;
		}

        public Quote(string qName, string em, int sId, int disc, int tPrice, bool sanct, 
            string custName, List<string> sNotes, List<Item> iList)
        {
            quoteName = qName;
            email = em;
            salesPersonId = sId;
            discount = disc;
            totalPrice = tPrice;
            sanctioned = sanct;
            customerName = custName;

            itemList = iList;
            noteList = sNotes;
        }

        public void fillItemList(List<TextBox> itemBoxList, List<TextBox> priceBoxList)
        {

        }

		public string getName()
		{
			return quoteName;
		}

		public string getCustName()
		{
			return customerName;
		}

		public string getEmail()
		{
			return email;
		}

		public int getId()
		{
			return quoteId;
		}

		public int getDiscount()
		{
			return discount;
		}

		public int getTotalPrice()
		{
			return totalPrice;
		}
		
		public bool getSanctioned()
		{
			return sanctioned;
		}

		public List<Item> getItemList()
		{
			return itemList;
		}

		public void setQuoteItems(List<Item> items)
		{
			itemList = items;
		}
    }
}
