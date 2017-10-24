using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z11
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
            if (x <0)
            { Console.Write("Значение Х должно неотрицательным");
                return;
            }
            double g;
            g = Math.Sqrt(x);
            Console.Write("{0:F4}", g);
        }
    }
}
