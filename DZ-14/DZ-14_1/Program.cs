
namespace DZ_14_1
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Cart cart = new Cart();
            Product banan = new Product(1,"Banan", 12);
            Product mango = new Product(2, "Mango", 122);
            Product milk = new Product(3, "Milk", 30);
            Product aplle = new Product(4,"aplle", 1);
            Shop sh = new Shop();
            sh.AddProduct(banan);
            sh.AddProduct(mango);
            sh.AddProduct(milk);
            sh.AddProduct(aplle);
           
           
            Console.WriteLine();

            sh.GetProductById(1);
            Console.WriteLine();
            sh.GetProductById(4);
            Console.WriteLine();

            sh.GetAllProducts();
            Console.WriteLine();

            sh.RemoveProduct(1);
            sh.GetAllProducts();
            Console.WriteLine();

            cart.AddToCart(banan);
            Console.WriteLine();
            cart.AddToCart(mango);
            Console.WriteLine();
            cart.AddToCart(aplle);
            Console.WriteLine();


            Console.ReadLine();

        }
    }
}

