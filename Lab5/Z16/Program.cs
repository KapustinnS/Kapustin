using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (x > y && x > z)
            {
                Console.Write(x);
            }
            if (y > x && y > z)
            {
                Console.Write(y);
            }
            if (z > x && z > y)
            {
                Console.Write(z);
            }
        }
    }
}