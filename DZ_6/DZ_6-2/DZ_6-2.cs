


Random rand = new Random();

int[] randNumbers = new int[20];

for (int i = 0; i < randNumbers.Length; i++)
{
    randNumbers[i] = rand.Next(-1,10);
}



PrintMassDoMissOne(randNumbers);

void PrintMassDoMissOne(int[] longArray)
{
    foreach (int i in longArray)
    {
        if (i == -1)
        {
            

            break;
        }
        else Console.WriteLine(i);
    }
}

Console.ReadKey();




