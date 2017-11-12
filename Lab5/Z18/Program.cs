using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z18
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a < 1000 || a > 9999)
            { Console.Write("Значение A дожно быть в интервале [1000, 9999]\n");
                return;
            }
            if ((a % 1000 - (a % 1000) % 100) / 100 == a % 10)
            {
                Console.Write("равно\n");
            }
            else
            {
                Console.Write("не равно\n");
            }
        }
    }
}