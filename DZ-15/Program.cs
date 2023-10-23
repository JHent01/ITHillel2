
using DZ_15;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        //1) Фільтрація: Дано список цілих чисел: {2, 5, 8, 12, 15, 18, 22}. Відфільтруйте всі числа, які більше 10.
        int[] nambrs = { 2, 5, 8, 12, 15, 18, 22 };

        var filter = nambrs.Where(nam => nam > 10).OrderBy(nam => nam);
        foreach (var nambr in filter)
        {
            Console.WriteLine(nambr);
        }
        Console.WriteLine();
        //2) Сортування: Дано список імен фруктів: {"Яблуко", "Апельсин", "Банан", "Ківі"}. Відсортуйте цей список в алфавітному порядку.
        string[] frykts = { "Яблуко", "Апельсин", "Банан", "Ківі" };
        var fryt = frykts.OrderBy(nam => nam);
        foreach (var item in fryt)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        //3) Видалення дублікатів: Дано список рядків: {"А", "Б", "В", "А", "Г", "В"}. Видаліть всі дублікати і поверніть унікальні рядки.

        string[] symbols = { "А", "Б", "В", "А", "Г", "В" };

        var duplicate = symbols.Distinct();
        foreach (var item in duplicate)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        //4) Підрахунок: Дано список оцінок студентів {85, 92, 78, 95, 88, 90}. Порахуйте, скільки студентів отримали більше 90 балів.
        int[] balls = { 85, 92, 78, 95, 88, 90 };
        var quantity = balls.Where(qua=>qua>90).ToList();
        Console.WriteLine(quantity.Count.ToString());
        Console.WriteLine();
        //5) Фільтрація та сортування: Дано список об'єктів, які представляють товари і мають поля "Назва" і "Ціна". Відфільтруйте товари, які мають ціну менше 50 гривень і відсортуйте їх за зростанням ціни.
        List<Fruit> list = new List<Fruit>()
        {
        new Fruit(10,"Aplle"),
        new Fruit(55, "Banan"),
        new Fruit(30, "Milk"),
        new Fruit(88, "Cola")
        };

        var sorting = list.Where(p=> p.price>50);  
        foreach (var item in sorting)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        //6) Пошук максимального за індексом: Дано список цілих чисел {10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом (позицією) в списку.
        int[] ints = { 10, 25, 8, 45, 15, 30, 55, 5 };
        var lastIndex = ints.Last();
        Console.WriteLine(lastIndex.ToString());
        Console.WriteLine();
        //У вас є список студентів з такими властивостями: Ім'я (Name), Оцінка (Grade) та Курс (Course). Вам потрібно вирішити наступні завдання, використовуючи LINQ:

        List<Students> students = new List<Students>()
        {
        new Students("Ola",100,1),
        new Students("Sasha",60,1),
        new Students("Max",50,4),
        new Students("Mark",93,2),
        new Students("Lila",100,3),
        new Students("Stich",88,4)
        };
        Console.WriteLine("Всі студенти: ");
        foreach (var item in students)
        {
            
            Console.WriteLine(item);
        }

        Console.WriteLine();

        var grades = students.Where(grad => grad.grade >= 90);
        Console.WriteLine("Студенти з оцінками вище 90 :");
        foreach (var student in grades)
        {
            
            Console.WriteLine(student);
        }

        Console.WriteLine();

        var gradeFilres= students.OrderBy(grad => grad.grade);
        Console.WriteLine("Сортування за оцінками ");
        foreach (var student in gradeFilres)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();

        var courses = students.GroupBy(cour => cour.course).OrderBy(groub=>groub.Key);
        foreach (var nameGroup in courses)
        {
            
            Console.WriteLine($"Курс: {nameGroup.Key} \t Кількість студентів на курсі: {nameGroup.Count()}" );
            foreach (var student in nameGroup)
            {
                Console.WriteLine($"\t{student.name}, {student.grade}");
            }
        }
        Console.ReadLine();
    }
}