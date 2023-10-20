
using DZ_14_2;
class Program
{
    static void Main(string[] args)

    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Queue<Order> queue = new Queue<Order>();

        Order one = new Order(1, "Oleg");

        Order two = new Order(2, "max");

        Order tri = new Order(3, "sas");

        

        queue.Enqueue(one);
        queue.Enqueue(two);
        queue.Enqueue(tri);
        while (queue.Count > 0)
        {
            Console.WriteLine("Людей в черзі " + queue.Count);

            var queue1 = queue.Dequeue();
            Console.WriteLine($"Сів за стіл {queue1.costomerName}");
          
        }
        Console.WriteLine("Всі столи зайняті");


        
    }
}