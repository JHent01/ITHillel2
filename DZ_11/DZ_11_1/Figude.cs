using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_1
{

    internal class Figude
    {

        int x;
        int y;

        private int X { get; }
        private int Y { get; }

        public Figude(int x,int y) 
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            this.X = x;
            this.Y = y;
            Console.WriteLine($"Початок фігури: {X},{Y}");
        }
        public int TryPurse(string parse)
        {
            int x=0;
            
            bool rtyparse = int.TryParse(parse, out int _);
            if (rtyparse == true)
            {
                x = int.Parse(parse);
            }
            return x;
        }
    }
}
