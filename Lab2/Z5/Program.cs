using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double d;
            d = double.Parse(a);
            double volume;
            volume = Math.PI * 4 * d*d*d / 3;
            Console.Write("{0:F4}", volume);
        }
    }
}
