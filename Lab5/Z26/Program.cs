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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((y <= 1.5 && x <= 2 && y >= 0.5) || (x >= 2))
            {
                Console.WriteLine("Точка принадлежит множеству");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит множеству");
            }
        }
    }
}