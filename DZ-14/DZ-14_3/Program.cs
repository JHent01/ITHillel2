using System.Collections.Generic;

Dictionary<int, string> namber = new Dictionary<int, string>() ;
Console.OutputEncoding = System.Text.Encoding.Unicode;


string ok;
try
{
    do
    {
        namber.Add(int.Parse(Console.ReadLine()), Console.ReadLine());
        Console.WriteLine("Номерів в телефонній книзі " + namber.Count);
        Console.WriteLine("Якщо бажаєте закінчити додавати номера напишіть Ok");
        ok = Console.ReadLine();
    }
    while (ok != "Ok");
    
}
catch
{
    Console.WriteLine("неправильно ввели номер або такий номер вже існує");
    Console.ReadLine();
}
Console.WriteLine("Ваші контакти : ");
foreach (var item in namber)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}



