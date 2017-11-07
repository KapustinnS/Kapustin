using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double a, b, c;
            if (x > 0)
            {
                a = Math.Pow(x, 2);
            }
            else
            { a = x;
            }
            if (y > 0)
            {
                b = Math.Pow(y, 2);
            }
            else
            {
                b = y;
            }
            if (z > 0)
            {
                c = Math.Pow(z, 2);
            }
            else
            {
                c = z;
            }
            Console.Write(a+";"+b+";"+c);
        }
    }
}
