using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z28
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double a = double.Parse(s);
            s = Console.ReadLine();
            double b = double.Parse(s);
            s = Console.ReadLine();
            double c = double.Parse(s);
            s = Console.ReadLine();
            double x = double.Parse(s);
            if (a < 0)
            { Console.Write("Подкоренное выражение должно быть неотрицательным\n");
                return;
            }
            if (a*b*c*x == 0)
            { Console.Write("Знаменатель не может быть равен нулю\n");
                return;
            }
            double result;
            result = 1 / Math.Sqrt(Math.Pow(a * x, 2) + b * x + c);
            Console.Write("{0:F4}\n", result);

        }
    }
}