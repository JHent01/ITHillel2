Console.OutputEncoding = System.Text.Encoding.Unicode;


Random rand = new Random();
Console.WriteLine("Ведіть число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Ведіть діапазон рандомних чисел від 0 до : ");
int ranNum=int.Parse(Console.ReadLine());
int dob = 1;

int[] masiv=new int[20];

masiv = RandomMatrix(20);

for (int i = 0;i < masiv.Length;i++)
 {
     if (num < masiv[i])
    {
        dob *= masiv[i];
        if (dob == 1) dob = 0;
    }
    
}

PrintMass(masiv);
Console.WriteLine("Добуток чисел більше за задане = " + dob);

#region
void PrintMass(int[] longArray)
{
    foreach (int i in longArray)
    {
        Console.Write(i + ", ");
    }
}
int[] RandomMatrix(int bound0)
{
    int[] masivRandom = new int[20];

    for (int i = 0; i < masivRandom.Length; i++)
    {
        masivRandom[i] = rand.Next(ranNum);
    }
    return masivRandom;
}
#endregion
Console.ReadKey();