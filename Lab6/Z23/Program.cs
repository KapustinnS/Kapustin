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
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            if (n < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }
            while (i <= n)
            {
                if (i % 20 != 0)
                {
                    Console.Write("#");
                    i++;
                }
                else
                {
                    Console.WriteLine("#");
                    i++;
                }
            }
        }
    }
}