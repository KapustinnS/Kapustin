using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            double a; 
            a = double.Parse(s);
            double t;
            t = 61 - a;
            if (t < 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным\n");
                return;
            }
            double result;
            result = 3*Math.Sqrt(t);
            Console.Write("{0:F4}\n", result);
        }
    }
}
