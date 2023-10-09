using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_1
{
    internal class Circle : Figude
    {
        int radius;
        public Circle() : base(3,5)
        {
            


            Console.WriteLine("Введіть радіус кола  ");
            radius = TryPurse(Console.ReadLine());
            Console.WriteLine($"Радіус кола: {radius} ");
        }
    }
}
