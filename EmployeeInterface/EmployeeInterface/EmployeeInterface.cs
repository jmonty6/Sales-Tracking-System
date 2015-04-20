using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInterface
{
    public partial class EmployeeInterface : Form
    {
        // Data Members

        private TextBox[] itemBoxList;
        private TextBox[] priceBoxList;

        private string[] itemList;
        private int[] priceList;

        // Methods

        public EmployeeInterface()
        {
            InitializeComponent();

            TextBox[] itemBoxList = new TextBox[8] {itemBox1, itemBox2, itemBox3, itemBox4, 
                itemBox5, itemBox6, itemBox7, itemBox8};
            TextBox[] priceBoxList = new TextBox[8] {priceBox1, priceBox2, priceBox3, priceBox4, 
                priceBox5, priceBox6, priceBox7, priceBox8};

            string[] itemList = new string[8];
            int[] priceList = new int[8];
        }

        private void EmployeeInterface_Load(object sender, EventArgs e)
        {

        }

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            QuoteSanctioner.searchCustomer();
        }

        private void quoteSearchButton_Click(object sender, EventArgs e)
        {
            QuoteSanctioner.searchQuote();
        }

        private void selectQuoteButton_Click(object sender, EventArgs e)
        {
            QuoteSanctioner.selectQuote();
        }

        // This method creates a quote object filled with values from the form
        // when the 'submit quote' button is pressed.
        private void submitQuoteButton_Click(object sender, EventArgs e)
        {
            fillItemList();
            fillPriceList();

            string quoteName = quoteNameBox.Text;
            string email = emailBox.Text;
            string salesPersonName = salesNameBox.Text;
            int discount = Int32.Parse(discountBox.Text);
            bool sanctioned = SanctionBox.Checked;

            QuoteSanctioner.submitQuote(itemList, priceList, quoteName, email, salesPersonName, discount, sanctioned);
        }

        private void fillItemList()
        {
            for (int i = 0; i < 8; i++)
            {
                if(itemBoxList[i].Visible)
                {
                    itemList[i] = itemBoxList[i].Text;
                }
            }
        }

        

        private void fillPriceList()
        {
            for (int i = 0; i < 8; i++)
            {
                if (priceBoxList[i].Visible)
                {
                    priceList[i] = Int32.Parse(priceBoxList[i].Text);
                }
            }
        }

    }
}
