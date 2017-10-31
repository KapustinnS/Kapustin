using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z31
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double x = double.Parse(a);
            double y;
            y = 7 * Math.Pow(x, 2) - 3 * x + 6;
            Console.Write("{0:F0}\n", y);
        }
    }
}
