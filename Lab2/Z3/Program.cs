using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
            if (x <= 0)
            {
                Console.Write("Значение x должно быть положительным");
                return;
            }
            double volume;
            volume = Math.Pow(x,3);
            Console.Write("{0:F4}", volume);
        }
    }
}
