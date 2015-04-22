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
        private string quoteName;
        private string email;
        private string salesPersonName;
        private int discount;
        private int totalPrice;
        private bool sanctioned;
        private string customerName;

        private List<string> noteList;
        private List<Item> itemList;

        public Quote(string qName, string em, string sName, int disc, int tPrice, bool sanct, 
            string custName, List<string> sNotes, List<Item> iList)
        {
            quoteName = qName;
            email = em;
            salesPersonName = sName;
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
    }
}
