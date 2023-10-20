using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_1
{
    internal class Cart
    {
        public List<Product> productsInCart = new List<Product>();
        
        public void AddToCart(Product product)
        {

            productsInCart.Add(product);
        }
        public void RemuveFromCart(int productId)
        {
            productsInCart.RemoveAt(productId);
        }
        public void GetTotalPrice()
        {
            
        }

    }
}
