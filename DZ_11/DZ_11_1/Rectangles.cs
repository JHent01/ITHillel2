using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_1
{
    internal class Rectangles:Figude
    {
        int width;
        int height;
        
        public Rectangles() : base(12,13) 
        {
            


            Console.WriteLine("Введіть штрину та висоту прямокутника  ");
            width =TryPurse(Console.ReadLine());
            height=TryPurse(Console.ReadLine());
            Console.WriteLine($"Ширина прямокутника: {width}  \n Виста прамокутника: {height} \n");


        }



    }
}
