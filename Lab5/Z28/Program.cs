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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Значение B должно быть неотрицательным");
                return;
            }
            if (c < 0)
            {
                Console.WriteLine("Значение C должно быть неотрицательным");
                return;
            }
            if (d < 0)
            {
                Console.WriteLine("Значение D должно быть неотрицательным");
                return;
            }
            double x, z;
            x = a * b;
            z = c * d;
            if (x <= z)
            {
                Console.WriteLine("Размещение возможно");
            }
            else
            {
                Console.WriteLine("Размещение невозможно");
            }
        }
    }
}