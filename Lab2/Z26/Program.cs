using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z26
{
    class Program
    {
        static void Main(string[] args)
        {
            string e = Console.ReadLine();
            double a = double.Parse(e);
            e = Console.ReadLine();
            double b = double.Parse(e);
            e = Console.ReadLine();
            double c = double.Parse(e);
            e = Console.ReadLine();
            double d = double.Parse(e); 
            if (a == 0)
            { Console.Write("Значение a должно быть не равно нулю\n");
                return;
            }
            if (d == 0)
            { Console.Write("Значение d должно быть не равно нулю\n");
                return;
            }
            double r;
            r = (a * d + b * c) / (a * d);
            Console.Write("{0:F4}\n", r);
        }
    }
}
