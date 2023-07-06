using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }
        public double TotalSpent()
        {
            double totalspent = 0;
            foreach(var order in Orders)
            {
                totalspent += order.Total();
            }
            return totalspent;
        }
        public List<string> ItemsOrdered()
        {
            var itemNames = new List<Item>();

            foreach(var order in Orders)
            {
                itemNames.AddRange(order.Items);  ;
            }
            List<string> allItems = itemNames.Select(Item=>Item.Name)
                .Distinct().ToList();
            return allItems;
            
        }
    }
}
