using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z37
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = double.Parse(Console.ReadLine());
            double t1 = double.Parse(Console.ReadLine());
            double v2 = double.Parse(Console.ReadLine());
            double t2 = double.Parse(Console.ReadLine());
            double volume;
            double temperature;
            if (v1 < 0)
            { Console.Write("Объем дложен быть неотрицательным\n");
                return;
            }
            if (v2 < 0 )
            { Console.Write("Обьем должен быть неотрицательным\n");
                return;
            }
            volume = v1 + v2;
            temperature = (t1 * v1 + t2 * v2) / (v1 + v2);
            Console.Write("{0:F4}\n{1:F4}\n", volume, temperature);
        }
    }
}
