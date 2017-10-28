using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z23
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = Console.ReadLine();
            double a = double.Parse(k);
            k = Console.ReadLine();
            double b = double.Parse(k);
            k = Console.ReadLine();
            double c = double.Parse(k);
            double discriminant;
            if (a == 0)
            {
                Console.Write("Данное уравнение не является квадратным\n" +
                  "");
                return;
            }
            discriminant = b*b-4*a*c;
            Console.Write("{0:F4}\n" +
                "", discriminant);
        }
    }
}
