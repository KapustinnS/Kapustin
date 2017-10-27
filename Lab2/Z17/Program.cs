using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z17
{
    class Program
    {
        static void Main(string[] args)
        {
            string l = Console.ReadLine();
            double v1 = double.Parse(l);
            l = Console.ReadLine();
            double v2 = double.Parse(l);
            if (v1+v2 < 0)
            { Console.Write("Скорость должна быть неотрицательна\n" +
                "");
                return;
            }
            l = Console.ReadLine();
            double d = double.Parse(l);
            double time;
            time = d / (v1 + v2);
            Console.Write("{0:F4}", time );
            Console.Write("\n" +
                "");
        }
    }
}
