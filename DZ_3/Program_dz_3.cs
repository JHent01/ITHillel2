using System.ComponentModel.Design;

Console.OutputEncoding = System.Text.Encoding.Unicode;
//парне непарне

    int a_Even;

Console.WriteLine("Введіть число :");
    a_Even = int.Parse(Console.ReadLine());

    if (a_Even % 2 == 0)
    {
        Console.WriteLine("парне");
    }
    else
    {
        Console.WriteLine("Непарне");
    }

Console.ReadKey();
// Необхідно написати консольну програму, де користувач вводитиме з клавіатури 2 числа. Числа будуть порівнюватися з наступним виведенням в консоль результату цього порівняння (чи рівні значення, а якщо ні, яке число більше/менше).
int num1,num2;

Console.WriteLine("Введіть перше число");
num1=int.Parse(Console.ReadLine());
Console.WriteLine("Ведіть друге число");
num2 = int.Parse(Console.ReadLine());
 
    if (num1 == num2)
{
    Console.WriteLine("Числа однакові");
}
else if (num1 > num2)
{
    Console.WriteLine($"Число {num1} більше");
}
else Console.WriteLine($"Число {num2} більше");

Console.ReadKey();

//Написати програму, яка виводить назву дня неділі за його номером (1 - понеділок, 7 - неділя)
int day;
Console.WriteLine("Введіть порядкоий номер тижня");
day = int.Parse(Console.ReadLine());
switch (day)
{
            case 1: Console.WriteLine("Понеділок");
             break;
            case 2: Console.WriteLine("Вівторок");
             break;
            case 3: Console.WriteLine("Середа");
             break;
            case 4: Console.WriteLine("Четверг");
             break;
            case 5: Console.WriteLine("П'яниця");
             break;
            case 6: Console.WriteLine("Субота");
             break;
            case 7: Console.WriteLine("Неділя");
             break;
      
}

if (0 > day & day > 7) Console.WriteLine("Такого дня тижня не існує");
Console.ReadKey();

//Написати програму, в якій користувач вводить номер місяця. 

int a;
a = MonthNum("Номер місяця: ");

PrintMonth(a);

 static void PrintMonth(int a)
{
    if ((a == 12) && (a <= 2) && (a! < 0))
    {
        Console.WriteLine("Зима");
    }
    else if ((a>2) && (a<=5))
    {
        Console.WriteLine("Весна");
    }
    else if ((a>5) && (a<=8)) 
    {
      Console.WriteLine("Літо");
    }
    else if ((a>8) && (a<=11)) 
    {
        Console.WriteLine("Осінь");
    }
    else { Console.WriteLine("Немає такого місяця на цій планеті"); }
}
static int MonthNum(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    bool cantPurse = int.TryParse(input, out int a);
    
    if (!cantPurse)  
    {
        Console.WriteLine("Інопрішілєнец?");
        return 1;
    }
    return a;
}
 Console.ReadKey();

//Напишіть програму, яка приймає від користувача число від 1 до 100. При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz. Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz. 

int in_put;
Console.Write("Введіть число от 1 до 100:");
in_put=int.Parse(Console.ReadLine());

if ((1 < in_put) && (in_put < 100))
{

    if (in_put % 15 == 0) Console.WriteLine("FizzBuzz"); 

    else if (in_put % 5 == 0) Console.WriteLine("Buzz");
    else if (in_put % 3 == 0) Console.WriteLine("Fizz");
    else Console.WriteLine("Число не ділиться на 5,3,15");
    
    
}
else Console.WriteLine("Число не в правильному діапазоні");
Console.ReadKey();
