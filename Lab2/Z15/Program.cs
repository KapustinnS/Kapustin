using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double s;
            s = double.Parse(a);
            if (s<273.15) 
            { Console.Write("Температура должна быть выше абсолютного нуля");
                return;
            }
            double z;
            z = 1.8;
            double temperatureInF;
            temperatureInF = (s * z) + 32;
            Console.Write("{0:F4}", temperatureInF);

        }
    }
}
