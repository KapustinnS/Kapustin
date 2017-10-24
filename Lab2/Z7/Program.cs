using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double g;
            g = double.Parse(a);
            double aInRad;
            aInRad = g * Math.PI / 180;
            Console.Write("{0:F4}", aInRad);
        }
    }
}
