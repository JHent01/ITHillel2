Console.OutputEncoding = System.Text.Encoding.Unicode;

int[,] matrix = new int[5, 5]; 
matrix = RandomMatrix(5,5);

PrintMass(matrix);

int mins = 0, plus=0, nul=0;

for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j =0 ; j<matrix.GetLength(1); j++)
    {
        if (matrix[i,j] <0 ) mins++;
        if (matrix[i,j] >0 ) plus++;
        else if (matrix[i,j]==0)  nul++;
    }
}

Console.WriteLine($"Чисел меньше нуля:{mins}\nЧисел більше нуля: {plus}\nНулів: {nul}");


void PrintMass(int[,] longArray)
{
    for (int i = 0;i < longArray.GetLength(0); i++) 
    {

        for (int j = 0; j <= longArray.GetUpperBound(1); j++)
        {
            Console.Write(longArray[i,j] + "\t");
        }
        Console.WriteLine("\n");
    }
}

int[,] RandomMatrix(int bound0, int bount1)
{
    Random rand = new Random();
    int[,] masivRandom = new int[5, 5];

    for (int i = 0; i <= masivRandom.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= masivRandom.GetUpperBound(1); j++)
        {
            masivRandom[i, j] = rand.Next(-10,10);
        }
    }
    return masivRandom;
}


Console.ReadKey();