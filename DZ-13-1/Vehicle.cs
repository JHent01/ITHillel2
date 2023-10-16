using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_13_1
{
    internal class Vehicle:IMovable
    {
       public int x, y;

        Point Position;
       
        public Vehicle()
        {

            Position = Move(x,y);
            
        }
        public Point Move(int x, int y)
        {

            Position = new Point(x, y);
            

            return Position;
        }
        public void print()
        {
            Console.WriteLine($"Car position={Position}");
        }
    }

    
}
