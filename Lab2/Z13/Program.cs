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
            if (a > 0)
            {
                Console.Write("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double result;
            result = 3*Math.Sqrt(61-a);
            Console.Write("{0:F4}", result);
        }
    }
}
