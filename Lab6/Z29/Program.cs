using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z29
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int i = 0;
            int n = 0;
            if (y <= 0)
            {
                Console.WriteLine("Значение Y должно быть положительным");
                return;
            }
            while (i <= y)
            {
                i++;
                if (y % i == 0)
                {
                    n++;
                }
            }
            if (n == 2)
            {
                Console.WriteLine("число простое");
            }
            else
            {
                Console.WriteLine("число не простое");
                return;
            }
        }
    }
}