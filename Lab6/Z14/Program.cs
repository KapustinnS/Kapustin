using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long k = 1;
            if (a < b)
            {
                while (a <= b)
                {
                    k = k * a;
                    a++;
                }
            }
            else
            {
                while (b <= a)
                {
                    k = k * b;
                    b++;
                }
            }
            Console.WriteLine(k);
        }
    }
}