using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.Write("Значение А должно быть неотрицательным\n");
            }
            if (b < 0)
            {
                Console.Write("Значение B должно быть неотрицательным\n");
            }
            if (c < 0)
            {
                Console.Write("Значение C должно быть неотрицательным\n");
            }
            if (a == b || b == c || c == a)
            {
                Console.Write("Треугольник является равнобедренным\n");
            }
            else
            {
                Console.Write("Треугольник не является равнобедренным\n");
            }
        }
    }
}
