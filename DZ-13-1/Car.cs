using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_13_1
{
    internal class Car:Vehicle
    {
        public Car()
        {
            
        }
        public void StartEngine()
        {
            Console.WriteLine("Start engine");

        }
        public void StopEngine() { Console.WriteLine("Stop engine"); }

    }
}
