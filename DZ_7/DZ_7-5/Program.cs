
using DZ_7_5;
Console.OutputEncoding = System.Text.Encoding.Unicode;

string[,] array = new string[3, 6] {
       { "YYkkrr", "5", "4", "3", "", "" },
        { "mmaahh", "5", "4", "3", "", "" },
        { "aangg", "5", "4", "3", "", ""  } };
int ser = 0,o;

void PrintArray(string[,] array)
{
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}


while (true)
    {
        int input = MultipleChoice(true, new ShopMenu());
        switch ((ShopMenu)input)
        {
            case ShopMenu.Переглянути_оцінки:
            Console.Clear();
                Console.WriteLine("Переглянути оцінки");
                PrintArray(array);
                
                break;
            case ShopMenu.Заповнити_журнал:
            Console.Clear();
                Console.WriteLine("Заповнити журнал");
            PrintArray(array);
                for (int i = 0 ;i<=array.GetUpperBound(0);i++ )
            {
                for(int j = 0; j<=array.GetUpperBound(1); j++ )
                {
                   
                    if (array[i,j]=="")
                    {
                        array[i,j]=(Console.ReadLine());
                        Console.Clear() ;
                        PrintArray(array);

                        
                    }
                }
            }
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {

                    if (array[i, j] == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Були заповнені не всі оцінки");


                    }
                 
                }
            }
            

                break;
            case ShopMenu.Середня_оцінка:
            Console.Clear();
                Console.WriteLine("Середня оцінка:");
            PrintArray(array);

            for (int i = 0 ; i<=array.GetUpperBound(0);i++)
            {
                for (int j = 1;j<=array.GetUpperBound(1);j++ )
                {
                    bool tryParse;
                   
                    tryParse = int.TryParse(array[i,j], out int _);


                    if (tryParse == false)
                    {
                        Console.Clear();
                        Console.WriteLine("  Ви не заповнили журнал  ");

                        Console.ReadKey();
                        
                        break;
                       
                    }
                       
                     if (tryParse==true) ser += int.Parse(array[i, j]);
                    
                }
            }
            o= ser/(array.Length-3);
            Console.WriteLine("Середня оцінка: "+o) ;
            ser = 0 ;
            o = 0;
                break;
            case ShopMenu.Вихід:
                Environment.Exit(0);
                break;
            default:
                break;
        }
        Console.ReadLine();
        Console.Clear();
    }
 static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine = 20, int optionsPerLine = 2,
   int startX = 1, int startY = 1)
{
    int currentSelection = 0;
    ConsoleKey key;
    Console.CursorVisible = false;
    int length = Enum.GetValues(userEnum.GetType()).Length;
    do
    {
        Console.Clear();

        for (int i = 0; i < length; i++)
        {
            Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

            if (i == currentSelection)
                Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(Enum.Parse(userEnum.GetType(), i.ToString()));

            Console.ResetColor();
        }

        key = Console.ReadKey(true).Key;

        switch (key)
        {
            case ConsoleKey.LeftArrow:
                {
                    if (currentSelection % optionsPerLine > 0)
                        currentSelection--;
                    break;
                }
            case ConsoleKey.RightArrow:
                {
                    if (currentSelection % optionsPerLine < optionsPerLine - 1)
                        currentSelection++;
                    break;
                }
            case ConsoleKey.UpArrow:
                {
                    if (currentSelection >= optionsPerLine)
                        currentSelection -= optionsPerLine;
                    break;
                }
            case ConsoleKey.DownArrow:
                {
                    if (currentSelection + optionsPerLine < length)
                        currentSelection += optionsPerLine;
                    break;
                }
            case ConsoleKey.Escape:
                {
                    if (canCancel)
                        return -1;
                    break;
                }
        }
    } while (key != ConsoleKey.Enter);

    Console.CursorVisible = true;

    return currentSelection;
}
