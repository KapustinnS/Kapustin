using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z19
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = Console.ReadLine();
            double i = double.Parse(k);
            k = Console.ReadLine();
            double t = double.Parse(k);
            k = Console.ReadLine();
            double a = double.Parse(k);
            double distance;
            if (t < 0)
            { Console.Write("Время должно быть положительным\n" +
                "");
                return; }
            if (i < 0)
            {
                Console.Write("Начальная скорость должно быть неотрицательна\n" +
                  "");
                return;
            }
            distance = (i * t) + (a * t * t / 2);
            Console.Write("{0:F4}", distance);
            Console.Write("\n" +
                "");
        }
    }
}
