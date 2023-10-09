using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_11_2
{
    internal class Transpord
    {
        string name;
        int maxSpeed;
        private string Name {  get;  }
        private int MaxSpeed { get; }
        internal Transpord(string name, int maxSpeed)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;



            this.Name = name;
            this.MaxSpeed = maxSpeed;
            Console.WriteLine($"Назва транспорту:{Name}\n Максимальна швидкість: {MaxSpeed}");

        }
        public int TryPurse(string parse)
        {
            int x = 0;

            bool rtyparse = int.TryParse(parse, out int _);
            if (rtyparse == true)
            {
                x = int.Parse(parse);
            }
            return x;
        }

    }
}
