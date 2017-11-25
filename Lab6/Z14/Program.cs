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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int k = 1;
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