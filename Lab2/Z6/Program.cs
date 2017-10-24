using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,c;
            a = Console.ReadLine();
            c = Console.ReadLine();
            double b;
            b = double.Parse(a);
            if (b<=0)
            { Console.Write("Значение d должно быть положительным");
                return;
            }
            double z;
            z = double.Parse(c);
            if (z<=0)
            { Console.Write("Значение z должно быть положительным");
                return;
            }
            double area;
            area = z * b / 2;
            Console.Write("{0:F4}", area);
        }
    }
}
