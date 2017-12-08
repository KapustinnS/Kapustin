using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z27
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            if ( a > b)
            {
                while (a >= b)
                {
                    if (a % 7 == 0)
                    {
                        sum += a;
                    }
                    a--;
                }
            }
            else
            {
                while (a <= b)
                {
                    if (a % 7 == 0)
                    {
                        sum += a;
                    }
                    a++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}