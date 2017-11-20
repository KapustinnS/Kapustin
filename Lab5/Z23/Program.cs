using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z23
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 2 && y >= 0) || (x >= 1 && y <= -1))
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