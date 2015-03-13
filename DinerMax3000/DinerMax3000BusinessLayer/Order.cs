using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000BusinessLayer
{
    public class Order
    {
        public List<MenuItem> items = new List<MenuItem>();

        public double Total
        {
            get 
            {
                double calcTotal = 0;
                foreach (MenuItem item in items)
                {
                    calcTotal = calcTotal + item.Price;
                }
                return calcTotal;
            }
        }
    }
}
