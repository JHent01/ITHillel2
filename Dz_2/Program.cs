using System.Runtime.InteropServices;
Console.OutputEncoding = System.Text.Encoding.Unicode;
int revers_a;
int revers_b;

//Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.
Console.Write("Введіть трьох значне число : ");

revers_b = int.Parse(Console.ReadLine());

revers_a = int.Parse(revers_b.ToString().Reverse().ToArray());


Console.WriteLine("Число з права на ліво:" + revers_a);
Console.ReadLine();

//Написати програму, яка обчислює квадрат будь-якого введеного числа.

int step_a;
Console.WriteLine("Введіть число :");

step_a = int.Parse(Console.ReadLine());
step_a = step_a * step_a;

Console.WriteLine("Число в квадраті :" + step_a);
Console.ReadLine();

//Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.

string mix_a;
Console.WriteLine("Введіть тьох значне число для перестановки його чисел:");
mix_a = Console.ReadLine();
Console.WriteLine("", mix_a[1], mix_a[0], mix_a[2]);
Console.ReadLine();

//Написати програму, яка обчислює середнє арифметичне двох чисел.

float mean_a, mean_b, buf;
Console.WriteLine("Введіть перше число:");
mean_a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть друге число:");
mean_b = int.Parse(Console.ReadLine());
buf = (mean_a + mean_b) / 2;
Console.WriteLine("Середнє арифметичне:" + buf);