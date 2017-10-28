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
            string a = Console.ReadLine();
            double x = double.Parse(a);
            double g;
            g = 1;
            double r;
            r = Math.Sqrt(g - Math.Pow(Math.Sin(x*Math.PI/180),2));
            Console.Write("{0:F4}\n", r);
        }
    }
}
