using System;

void PrintMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {

        for (int j = 0; j < Array.GetUpperBound(1); j++)
        {
            Console.Write(Array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}

int[,] RandomMatrix(int bound0, int bount1)
{
    Random rand = new Random();
    int[,] masivRandom = new int[bound0, bount1];

    for (int i = 0; i < masivRandom.GetUpperBound(0); i++)
    {
        for (int j = 0; j < masivRandom.GetUpperBound(1); j++)
        {
            masivRandom[i, j] = rand.Next(-10, 10);
        }
    }
    return masivRandom;
}

void PrintArray(int[] Array)
{
    foreach (int i in Array)
    {
        Console.Write(i + "   ");
    }
}

int[] RandomArrayTo100(int bound0)
{
    Random rand = new Random();

    int[] masivRandom = new int[bound0];

    for (int i = 0; i < masivRandom.Length; i++)
    {
        masivRandom[i] = rand.Next(100);
    }
    return masivRandom;
}

