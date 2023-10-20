using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_1
{
    internal class Shop
    {
        public List<Product> productsInShop = new List<Product>();
        public void AddProduct (Product product)
        {
            productsInShop.Add(product);
            
        }
        public void RemoveProduct (int productId) 
        {
            productsInShop.RemoveAt(productId-1);//Що б користувач міг вводити айді товару звичний образом від 1
        }
        public void GetProductById(int productId)
        {
            Product? product = productsInShop.Find(i=>i.id == productId)  ;
            if (product == null) { Console.WriteLine("Айді невірне"); }
            else { Console.WriteLine(product.ToString()); }
        }
        public void GetAllProducts()
        {
           

            foreach (var item in productsInShop)
            {
                Console.WriteLine(item);
            }
        }
    }
}
