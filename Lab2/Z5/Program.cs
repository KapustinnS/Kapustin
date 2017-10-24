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
            if (d <=0)
            { Console.Write("Значение d должно положительным");
                return;
            }
            double volume;
            volume = Math.PI * 4 * Math.Pow(d,3) / 3;
            Console.Write("{0:F4}", volume);
        }
    }
}
