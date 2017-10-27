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
            string t = Console.ReadLine();
            double x = double.Parse(t);
            t = Console.ReadLine();
            double y = double.Parse(t);
            double r;
            if (y < 0)
            {
                Console.Write("Значение y должно быть неотрицательным\n" +
                    "");
                return;
            }
            if (x + Math.Sqrt(y) < 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным\n" +
                    "");
                return;
            }
            r = -5 * Math.Sqrt(x + Math.Sqrt(y));
            Console.Write("{0:F4}", r);
            Console.Write("\n" +
                "");
        }
    }
}
