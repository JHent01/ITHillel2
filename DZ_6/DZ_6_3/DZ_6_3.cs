
using System.Collections.Generic;

Random rand = new Random();

int[] masivRandom = new int[20];

for (int i = 0; i < masivRandom.Length; i++)
{
    masivRandom[i] = rand.Next(100);
}


int[] masivRandom2 = new int[20];

for (int i = 0; i < masivRandom2.Length; i++)
{
    masivRandom2[i] = rand.Next(100, 200);
}





int[] LongerMasiv=new int[(masivRandom.Length + masivRandom2.Length)];

masivRandom.CopyTo(LongerMasiv, 0);
masivRandom2.CopyTo(LongerMasiv, masivRandom.Length);

PrintMass(LongerMasiv);

void PrintMass(int[] longArray)
{
    foreach (int i in longArray)
    {
        Console.Write(","+i);
    }
}


Console.ReadKey();