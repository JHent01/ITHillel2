using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_1
{
    internal class Product
    {

        //public List<Product> products = new List<Product>();
        public int id;
        public string name;
        public int price;

        public Product(int id, string name, int price)
        {

            this.id = id;
            this.name = name;
            this.price = price;
            
        }
      
        public override string ToString()
        {
            return $"Id={id},Name={name},Price={price}";
        }

        
    }
}
