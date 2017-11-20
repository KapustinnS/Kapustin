using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z22
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y <= 4 && y >= 2 && x >= 1)
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