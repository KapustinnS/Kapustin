using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z24
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double m1 = double.Parse(a);
            a = Console.ReadLine();
            double m2 = double.Parse(a);
            a = Console.ReadLine();
            double d = double.Parse(a);
            double g;
            g = 9.8067;
            double force;
            if (d <= 0)
            {
                Console.Write("Дистанция должна быть неотрицательной\n");
                return;
            }
            if (m1 <= 0)
            {
                Console.Write("Масса должна быть неотрицательной\n");
                return;
            }
            if (m2 <= 0)
            { Console.Write("Масса должна быть неотрицательной\n");
                return;
            }
            force = g * m1 * m2 / Math.Pow(d,2);
            Console.Write("{0:F4}\n", force);
        }
    }
}