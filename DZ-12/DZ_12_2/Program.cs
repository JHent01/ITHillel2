namespace DZ_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть ключ доступу ");

            string pass = Console.ReadLine();
            if (pass == "Ex")
            {
                Console.WriteLine("Ви ввели ключ доступу Експерт");
                ExpertDocumentWorker asd = new ExpertDocumentWorker();
                
            }
            else if (pass == "Pro")
            {
                Console.WriteLine("Ви ввели ключ доступу Про");
                ProDocumentWorker fof = new ProDocumentWorker();
            }
            else
            {
                Console.WriteLine("Ви ввели неправильний ключ доступу або не ввели ключ доступу, вам дали доступ Базовий  ");
                BasicWorker ff = new BasicWorker();

             
            }
        }


    } 
}
