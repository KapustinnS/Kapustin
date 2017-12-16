using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z25
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 1 && x <= 3 && y <= -1 && y >= -2)
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