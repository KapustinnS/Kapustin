using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a < b && b < c)
            {
                Console.Write("Выполняется\n");
            }
            else
            {
                Console.Write("Не выполняется\n");
            }
        }
    }
}
