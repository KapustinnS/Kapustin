using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sum = 0;
            if (a >= b)
            {
                while (b <= a)
                {
                    sum += Math.Pow(a,2);
                    a--;

                }
                Console.WriteLine(sum);
            }
            else
            {
                while (a <= b)
                {
                    sum += Math.Pow(a,2);
                    a++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}