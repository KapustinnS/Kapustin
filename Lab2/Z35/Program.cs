using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z35
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double result;
            result = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(x1, 2));
            Console.Write("{0:F4}\n", result);
        }
    }
}
