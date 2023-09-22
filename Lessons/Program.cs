using LibleryMetod;


internal class Program
{
    private static void Main(string[] args)
    {
        int[] array2 = new int[10] ;
        array2 = Metods.RandomArrayTo100(10);
        Metods.PrintArray(array2);

        Console.WriteLine("Hello, Wo1112rld!");
        Console.ReadKey();
    }
}