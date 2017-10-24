using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int t;
            t = int.Parse(a);
            double result;
            result = 5 * Math.Cos(t * Math.PI / 180);
            Console.Write("{0:F4}", result);
        }
    }
}
