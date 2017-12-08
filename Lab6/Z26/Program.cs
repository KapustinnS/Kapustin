using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z26
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int a = 100;
            int b = 1000;
            Console.Write("Ход решения: ");
            while ( a <= b)
            {
                if (a % 13 != 0)
                {
                    Console.Write(a + " ");
                }
                else
                {
                    Console.Write(a + "+ ");
                    x++;
                }
                a++;
            }
            Console.WriteLine("Ответ: " + x);
        }
    }
}
