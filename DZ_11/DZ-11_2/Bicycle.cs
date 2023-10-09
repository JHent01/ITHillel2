using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_2
{
    internal class Bicycle:Transpord
    {
        int speed;
        string name;
        string tipBicycle;
        public Bicycle(int speed, string name,string tipBicycle):base(name,speed)
        {
            this.speed = speed;
            this.name = name;
            this.tipBicycle = tipBicycle;
            Console.WriteLine($"Тип велосипеда: {tipBicycle}");
        }
    }
}
