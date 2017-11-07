using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            if (x == y || y == z || x == z)
            {
                Console.Write("Среди чисел есть равные\n");
            }
            else
            {
                Console.Write("Числа не равны друг другу.\n");
            }
        }
    }
}