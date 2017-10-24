using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            str = Console.ReadLine();
            double x;
            x = double.Parse(str);
            if (x <=0)
            { Console.Write("Значение х должно быть положительным");
                    return;
            }
            double area;
            area = 6 * Math.Pow(x,2);
              Console.Write("{0:f4}", area);
        }
    }
}
