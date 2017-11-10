using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z20
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            double m = double.Parse(t);
            t = Console.ReadLine();
            double v = double.Parse(t);
            t = Console.ReadLine();
            double h = double.Parse(t);
            double g;
            g = 9.8067;
            double kineticEnergy, potentialEnergy;
            if (m < 0)
            {
                Console.Write("Значение mass должно быть положительным\n");
                return;
            }
            if (v < 0)
            {
                Console.Write("Значение velocity должно быть положительным\n");
                return;
            }
            if (h < 0)
            {
                Console.Write("Значение height должно быть неотрицательным\n");
                return;
            }
            kineticEnergy = (m*v*v)/2;
            potentialEnergy = m * g * h;
            Console.Write("Кинетическая энергия составляет: {0:F4} Дж\nПотенциальная энергия составляет: {1:F4} Дж\n", kineticEnergy, potentialEnergy);
        }
    }
}