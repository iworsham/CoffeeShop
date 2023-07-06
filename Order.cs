using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Order
    {
        public List<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }

        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.PriceInDollars();
            }
            return total;
        }
    }
}
