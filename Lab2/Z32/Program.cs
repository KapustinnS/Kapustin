using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z32
{
    class Program
    {
        static void Main(string[] args)
        {
            string z = Console.ReadLine();
            double a = double.Parse(z);
            double b;
            b = 12 * Math.Pow(a, 2) + 7 * a - 16;
            Console.Write("{0:F4}\n", b);
        }
    }
}
