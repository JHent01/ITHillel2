using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12_2
{
    public static class MathUtilite
    {

        public static double Pluse(double x, double y)
        {

            double result = x + y;
            Console.WriteLine(result);
            return result;
        }

        public static double Minus(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
            return result;
        }
        public static int Multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
            return result;
        }
        
        
             public static int Division(int x, int y)
             {
                try
                {
                int result = x / y;
                Console.WriteLine(result);
                return result;
                }
                catch 
                {
                Console.WriteLine("Division by zero");
                return 0 ;
                }
           

             }
          
   

    }
}
