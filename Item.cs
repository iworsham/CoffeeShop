using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Item
    {
        public string Name { get; set; }
        public int PriceInCents { get; set; }


        public Item (string name , int priceInCents)
        {
            Name = name;
            PriceInCents = priceInCents;
        }

        public double PriceInDollars()
        {
            return (double)PriceInCents / 100;
        }
    }
    
}
