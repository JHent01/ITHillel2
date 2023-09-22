



using DZ_7_5;

while (true)
    {
        int input = MultipleChoice(true, new ShopMenu());
        switch ((ShopMenu)input)
        {
            case ShopMenu.Start:
                Console.WriteLine("Your choice: Start");
                break;
            case ShopMenu.Settings:
                Console.WriteLine("Your choice: Settings");
                break;
            case ShopMenu.About:
                Console.WriteLine("Your choice: About");
                break;
            case ShopMenu.Exit:
                Environment.Exit(0);
                break;
            default:
                break;
        }
        Console.ReadLine();
        Console.Clear();
    }
 static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine = 18, int optionsPerLine = 2,
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
