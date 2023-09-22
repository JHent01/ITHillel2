





for (int i = 0; i <= 100; i++)
{
    
   
    Console.Write(i+"\t");
    
}

Console.ReadKey();
int a = 0;

for (int b= 0; b <= 100; b++) 
{
    a += b;
    
}
Console.Write(a);

Console.ReadKey();

for (int gus = 0; gus < 32;  gus++)
{
    for (int krol = 0 ; krol < 16;krol++)
    {
        if (gus *2 + krol * 4 ==64) Console.Write($"gus {gus} - krol {krol} ");
    }
}
Console.ReadKey();

Random random = new Random();
int num = random.Next();
Console.WriteLine(num);
byte countDigit = CountDigit(num);
Console.WriteLine("Число", countDigit);


byte CountDigit(int num)
{
    byte count = 1;

    while (num > 9)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.WriteLine(countDigit);




Console.ReadKey();  
