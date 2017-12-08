using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int i = 0;
            if (a < 0)
            {
                Console.WriteLine("Значение Х должно быть положительным");
                return;
            }
            while (i <= a)
            {
                i++;
                if (a % i == 0)
                {
                    Console.Write(i + " ");

                }
            }

        }
    }
}