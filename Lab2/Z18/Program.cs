using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double x1 = double.Parse(a);
            a = Console.ReadLine();
            double x2 = double.Parse(a);
            a = Console.ReadLine();
            double x3 = double.Parse(a);
            double r;
            r = (x1*x2) + (x1*x3) + (x2*x3);
            Console.Write("{0:F4}", r);
            Console.Write("\n" +
                "");
        }
    }
}
