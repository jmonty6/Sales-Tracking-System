using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInterface
{
    class Item
    {
        private string description;
        private int price;

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string desc)
        {
            description = desc;
        }

        public int getPrice()
        {
            return price;
        }

        public void setPrice(int pr)
        {
            price = pr;
        }
    }
}
