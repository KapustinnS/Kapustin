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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y >= -2 && y <= 1.5)
            {
                Console.Write("Точка принадлежит множеству\n");
            }
            else
            {
                Console.Write("Точка не принадлежит множеству\n");
            }
        }
    }
}