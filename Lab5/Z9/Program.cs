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
            double radius,edge,d;
            if (Sc < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;
            }
            if (Ss < 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
                return;
            }
            radius = Math.Sqrt(Sc / Math.PI);
            edge = Math.Sqrt(Ss);
            d = radius * 2;
            if (d < edge)
            {
                Console.WriteLine("Круг уместится в квадрате");
            }
            else
            {
                Console.WriteLine("Круг не поместится в квадрате");
            }
        }
    }
}