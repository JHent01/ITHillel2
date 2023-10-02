using DZ_10_2;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Введіть свій логін, ім'я, фамілію, вік");

     
        
        User user1 = new User(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),Console.ReadLine());





        Console.ReadKey();
    }
}