using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z22
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double m = double.Parse(a);
            a = Console.ReadLine();
            double z = double.Parse(a);
            double g;
            g = 9.8067;
            if (m <= 0)
            { Console.Write("Масса должна быть положительной\n" +
                "");
                return;
            }
            double result;
            result = m * g * Math.Cos(z * Math.PI / 180);
            Console.Write("{0:F4}\n" +
                "", result);
        }
    }
}
