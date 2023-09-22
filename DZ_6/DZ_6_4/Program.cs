Random rand = new Random();

int[] randNumbers = new int[20];

for (int i = 0; i < randNumbers.Length; i++)
{
    randNumbers[i] = rand.Next(101);
}





PrintMass(randNumbers);

void PrintMass(int[] longArray)
{
    foreach (int i in longArray)
    {
        Console.WriteLine(i);
    }
}

int num = int.Parse(Console.ReadLine());

    randNumbers[num-1] = 000;


Console.WriteLine($"You delete num {num}");

PrintMass(randNumbers);


Console.ReadKey();

