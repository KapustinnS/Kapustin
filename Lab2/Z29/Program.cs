using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z29
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double x = double.Parse(a);
            if (x < 5)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным\n");
                return;
            }
            double r;
            r = (Math.Sqrt(x + 5) + Math.Sqrt(x - 5)) / (2 * Math.Sqrt(x));
            Console.Write("{0:F4}\n", r);
        }
    }
}
