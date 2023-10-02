using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_1
{
    internal class Rectangle
    {
       
       public double side1;
       public double side2;
        public double Side1 { get; }
        public double Side2 { get; }
        private double Area { get; }
      
        private double Perimeter { get; }
      
        public Rectangle( double side1,double side2)

        {
            this.side1 = side1;
            this.side2 = side2;
            this.Area=AreaCalculator(side1, side2);
            this.Perimeter = PerimeterCalculator(side2, side1);

            Console.WriteLine("Перша сторона "+side1);
            Console.WriteLine("Друга сторона "+side2);

            Console.WriteLine("Площа прямокутника = "+Area);
            Console.WriteLine("Периметр прямокутника = "+Perimeter);

        }
        #region
        public double AreaCalculator(double side1, double side2)
        {
            return Math.Abs(side1 * side2);
        }
        public double PerimeterCalculator(double side1, double side2)
        {
            return Math.Abs(side1 * 2) + (side2 * 2);
        }
        #endregion

    }
}
