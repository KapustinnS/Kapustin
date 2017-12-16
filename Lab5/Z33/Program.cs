using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z33
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int x = 0;
            if (t < 0 || t > 59)
            {
                Console.WriteLine("Значение T должно быть в интервале[0, 59]");
                return;
            }
            if (t == 0)
            {
                Console.WriteLine("Зеленый");
                return;
            }
            x = t % 10;
            if (x == 1 || x == 2 || x == 5 || x == 6 || x == 7 || x == 8)
            {
                Console.WriteLine("Зеленый");

            }
            else
            {
                Console.WriteLine("Красный");
            }
        }
    }
}