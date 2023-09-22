
    Random rand = new Random();

    int[] randNumbers = new int[20];

    for (int i = 0; i < randNumbers.Length; i++)
    {
        randNumbers[i] = rand.Next(101);
    }



    Random randomInt = new Random();
    int a = randomInt.Next();

    int[] longArray = new int[randNumbers.Length + 1];

    for (int i = 0; i < randNumbers.Length; i++)

    {
        longArray[i + 1] = randNumbers[i];
    }

    longArray[longArray.Length - randNumbers.Length - 1] = a;



    PrintMass(longArray);

void PrintMass(int[] longArray)
{
    foreach (int i in longArray)
    {
        Console.WriteLine(i);
    }
}

Console.ReadKey();



