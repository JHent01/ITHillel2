using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15
{
    internal class Fruit
    {
        public int price { get; set; }
        public string name { get; set; }
        public Fruit(int price, string name)
        {
            this.price = price;
            this.name = name;
        }
        public override string ToString()
        {
            return "Price: " + price + "   Name: " + name;
        }
    }
}
