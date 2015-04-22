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

            // fill the textbox lists with their respective textboxes

			TextBox[] itemBoxList = new TextBox[8] {itemBox1, itemBox2, itemBox3, itemBox4, 
                itemBox5, itemBox6, itemBox7, itemBox8};
			TextBox[] priceBoxList = new TextBox[8] {priceBox1, priceBox2, priceBox3, priceBox4, 
                priceBox5, priceBox6, priceBox7, priceBox8};

            // Initialize itemList and priceList

			string[] itemList = new string[8];
			int[] priceList = new int[8];

            this.Width = 420;
            this.Height = 440;
		}

		private void EmployeeInterface_Load(object sender, EventArgs e)
		{
			Authentication login = new Authentication();
			login.ShowDialog();
			if (!login.isValid())
			{
				Dispose();
			}
		}

        // Searches for a quote by customer name
		private void customerSearchButton_Click(object sender, EventArgs e)
		{
            // Pass the value in the customer search box to QuoteSanctioner

			QuoteSanctioner.searchCustomer(customerSearchBox.Text);
		}

        // Searches for a quote by quote name
		private void quoteSearchButton_Click(object sender, EventArgs e)
		{
            // Pass the value in the quote search box to QuoteSanctioner

			QuoteSanctioner.searchQuote(quoteSearchBox.Text);
		}

        // Displays the quote information for the selected quote
		private void selectQuoteButton_Click(object sender, EventArgs e)
		{
            if(selectQuoteBox.SelectedIndex > -1)
            {
                QuoteSanctioner.selectQuote();

                customerInfoBox.Visible = true;
                quoteGroupBox.Visible = true;

                this.Width = 1130;
                this.Height = 670;
            }
		}

		// Creates a quote object filled with values from the form
		// when the 'submit quote' button is pressed.
		private void submitQuoteButton_Click(object sender, EventArgs e)
		{
            // fill the item and price lists

			fillItemList();
			fillPriceList();

            // put each box's value into variables to pass to QuoteSanctioner

			string quoteName = quoteNameBox.Text;
			string email = emailBox.Text;
			string salesPersonName = salesNameBox.Text;
			int discount = Int32.Parse(discountBox.Text);
			bool sanctioned = SanctionBox.Checked;

			QuoteSanctioner.submitQuote(itemList, priceList, quoteName, email, salesPersonName, discount, sanctioned);
		}

        // fills them item list with the text of any item boxes that are currently visible
		private void fillItemList()
		{
			for (int i = 0; i < 8; i++)
			{
				if (itemBoxList[i].Visible)
				{
					itemList[i] = itemBoxList[i].Text;
				}
			}
		}


        // Fills the price list with the values of any price boxes that are currently visible
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

        // These methods are for each + / - button to change visibility on the required fields

        private void itemButton1_Click(object sender, EventArgs e)
        {
            itemBox2.Visible = true;
            priceBox2.Visible = true;
            itemButton2.Visible = true;
            itemButtonR2.Visible = true;

            itemButton1.Visible = false;
        }

        private void itemButton2_Click(object sender, EventArgs e)
        {
            itemBox3.Visible = true;
            priceBox3.Visible = true;
            itemButton3.Visible = true;
            itemButtonR3.Visible = true;

            itemButton2.Visible = false;
            itemButtonR2.Visible = false;
        }

        private void itemButton3_Click(object sender, EventArgs e)
        {
            itemBox4.Visible = true;
            priceBox4.Visible = true;
            itemButton4.Visible = true;
            itemButtonR4.Visible = true;

            itemButton3.Visible = false;
            itemButtonR3.Visible = false;
        }

        private void itemButton4_Click(object sender, EventArgs e)
        {
            itemBox5.Visible = true;
            priceBox5.Visible = true;
            itemButton5.Visible = true;
            itemButtonR5.Visible = true;

            itemButton4.Visible = false;
            itemButtonR4.Visible = false;
        }

        private void itemButton5_Click(object sender, EventArgs e)
        {
            itemBox6.Visible = true;
            priceBox6.Visible = true;
            itemButton6.Visible = true;
            itemButtonR6.Visible = true;

            itemButton5.Visible = false;
            itemButtonR5.Visible = false;
        }

        private void itemButton6_Click(object sender, EventArgs e)
        {
            itemBox7.Visible = true;
            priceBox7.Visible = true;
            itemButton7.Visible = true;
            itemButtonR7.Visible = true;

            itemButton6.Visible = false;
            itemButtonR6.Visible = false;
        }

        private void itemButton7_Click(object sender, EventArgs e)
        {
            itemBox8.Visible = true;
            priceBox8.Visible = true;
            itemButtonR8.Visible = true;

            itemButton7.Visible = false;
            itemButtonR7.Visible = false;
        }

        private void itemButtonR2_Click(object sender, EventArgs e)
        {
            itemBox2.Visible = false;
            itemBox2.Text = "";
            priceBox2.Visible = false;
            priceBox2.Text = "";
            itemButton2.Visible = false;
            itemButtonR2.Visible = false;

            itemButton1.Visible = true;
        }

        private void itemButtonR3_Click(object sender, EventArgs e)
        {
            itemBox3.Visible = false;
            itemBox3.Text = "";
            priceBox3.Visible = false;
            priceBox3.Text = "";
            itemButton3.Visible = false;
            itemButtonR3.Visible = false;

            itemButton2.Visible = true;
            itemButtonR2.Visible = true;
        }

        private void itemButtonR4_Click(object sender, EventArgs e)
        {
            itemBox4.Visible = false;
            itemBox4.Text = "";
            priceBox4.Visible = false;
            priceBox4.Text = "";
            itemButton4.Visible = false;
            itemButtonR4.Visible = false;

            itemButton3.Visible = true;
            itemButtonR3.Visible = true;
        }

        private void itemButtonR5_Click(object sender, EventArgs e)
        {
            itemBox5.Visible = false;
            itemBox5.Text = "";
            priceBox5.Visible = false;
            priceBox5.Text = "";
            itemButton5.Visible = false;
            itemButtonR5.Visible = false;

            itemButton4.Visible = true;
            itemButtonR4.Visible = true;
        }

        private void itemButtonR6_Click(object sender, EventArgs e)
        {
            itemBox6.Visible = false;
            itemBox6.Text = "";
            priceBox6.Visible = false;
            priceBox6.Text = "";
            itemButton6.Visible = false;
            itemButtonR6.Visible = false;

            itemButton5.Visible = true;
            itemButtonR5.Visible = true;
        }

        private void itemButtonR7_Click(object sender, EventArgs e)
        {
            itemBox7.Visible = false;
            itemBox7.Text = "";
            priceBox7.Visible = false;
            priceBox7.Text = "";
            itemButton7.Visible = false;
            itemButtonR7.Visible = false;

            itemButton6.Visible = true;
            itemButtonR6.Visible = true;
        }

        private void itemButtonR8_Click(object sender, EventArgs e)
        {
            itemBox8.Visible = false;
            itemBox8.Text = "";
            priceBox8.Visible = false;
            priceBox8.Text = "";
            itemButtonR8.Visible = false;

            itemButton7.Visible = true;
            itemButtonR7.Visible = true;
        }

        private void noteButton1_Click(object sender, EventArgs e)
        {
            noteBox2.Visible = true;
            noteButton2.Visible = true;
            noteButtonR2.Visible = true;

            noteButton1.Visible = false;
        }

        private void noteButton2_Click(object sender, EventArgs e)
        {
            noteBox3.Visible = true;
            noteButtonR3.Visible = true;

            noteButton2.Visible = false;
            noteButtonR2.Visible = false;
        }

        private void noteButtonR2_Click(object sender, EventArgs e)
        {
            noteBox2.Visible = false;
            noteButton2.Visible = false;
            noteButtonR2.Visible = false;

            noteButton1.Visible = true;
        }

        private void noteButtonR3_Click(object sender, EventArgs e)
        {
            noteBox3.Visible = false;
            noteButtonR3.Visible = false;

            noteButton2.Visible = true;
            noteButtonR2.Visible = true;
        }
	}
}
