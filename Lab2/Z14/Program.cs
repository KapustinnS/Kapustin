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
            string t;
            t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            int b;
            t = Console.ReadLine();
            b = int.Parse(t);
            if (b>0)
            { Console.Write("Значение B должно быть не положительным");
                return;
            }
            double result;
            result = a * Math.Sqrt (- 7 * b);
            Console.Write("{0:F4}", result);     
        }
    }
}
