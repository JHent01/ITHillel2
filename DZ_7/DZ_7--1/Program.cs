using System;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Random rand = new Random();

int[] masivRandom = new int[20];
masivRandom = RandomMasiv(20);
int sum = 0;

for (int i = 2; i < masivRandom.Length; i += 2)
{
    sum += masivRandom[i];
}

PrintMass(masivRandom);
Console.WriteLine("Сумма чисел на парних індексах = " + sum);


#region
void PrintMass(int[] longArray)
{
    foreach (int i in longArray)
    {
        Console.Write(i + ", ");
    }
}
int[] RandomMasiv(int bound0)
{
    int[] masivRandom = new int[20];

    for (int i = 0; i < masivRandom.Length; i++)
    {
        masivRandom[i] = rand.Next(10);
    }
    return masivRandom;
}
#endregion


Console.ReadKey();