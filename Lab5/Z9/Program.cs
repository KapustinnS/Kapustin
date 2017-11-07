using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sc = double.Parse(Console.ReadLine());
            double Ss = double.Parse(Console.ReadLine());
            double Sc1, Ss1, z;
            if (Sc < 0)
            {
                Console.Write("Площадь круга должна быть положительной\n");
                return;
            }
            if (Ss < 0)
            {
                Console.Write("Площадь квадрата должна быть положительной\n");
                return;
            }
            Sc1 = Math.Sqrt(Sc / Math.PI);
            Ss1 = Math.Sqrt(Ss);
            z = Sc1 * 2;
            if (z < Ss1)
            {
                Console.Write("Круг уместится в квадрате\n");
            }
            else
            {
                Console.Write("Круг не поместится в квадрате\n");
            }
        }
    }
}