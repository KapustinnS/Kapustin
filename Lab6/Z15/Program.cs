using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 20;
            double v;
            double s = 0;
            Console.Write("Ход решения: 0+");
            while (a <= 40)
            {
                v = Math.Pow(a, 3);
                Console.Write(v + "=");
                s += v;
                Console.Write(s +"+");
                a++;
            }
            Console.WriteLine("0 = ");
            Console.WriteLine("Ответ: " + s);
        }
    }
}