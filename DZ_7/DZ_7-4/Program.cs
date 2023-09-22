Console.OutputEncoding = System.Text.Encoding.Unicode;

string[] array= new string[] { "Гаврилюк", "Павлюк", "Козак", "Демченко", "Міщенко", "Волошин" , "Мельник" };
Array.Sort(array);
var str = string.Join(" ", array);
Console.WriteLine(str);