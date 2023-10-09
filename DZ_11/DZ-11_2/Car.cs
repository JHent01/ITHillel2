using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_2
{
    internal class Car : Transpord
    {
        string name;
        int speed;
        int dor;

        public Car (string name,int speed): base (name, speed)
        {

            this.speed = speed;
            this.name = name;
            Console.WriteLine("Ввудіть кількість дверей ");
            this.dor=TryPurse(Console.ReadLine());
            Console.WriteLine($"Кількість дверей: {dor}");

        }


    }
}
