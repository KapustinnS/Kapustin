using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double s;
            double s1;
            if (r < 0)
            {
                Console.Write("Радиус должен быть положительным\n");
                return;
            }
            if (e < 0)
            {
                Console.Write("Сторона квадрата должна быть положительна\n");
                return;
            }
            s = Math.Pow(e,2);
            s1 = Math.PI * Math.Pow(r, 2);
            if (s1 > s)
            {
                Console.Write("Площадь круга {0:F4} больше площади квадрата {1:F4}\n", s1, s);   
            }
            else
            {
                Console.Write("Площадь квадрата {1:F4} больше площади круга {0:F4}\n", s1, s);
            }
        }
    }
}
