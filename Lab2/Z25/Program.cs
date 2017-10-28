using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z25
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();
            double a = double.Parse(v);
            v = Console.ReadLine();
            double b = double.Parse(v);
            v = Console.ReadLine();
            double c = double.Parse(v);
            double result;
            result = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)-2 * a * b * Math.Cos(c * Math.PI / 180));
            Console.Write("{0:F4}\n", result);
        }
    }
}
