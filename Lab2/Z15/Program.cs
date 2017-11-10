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
            if (s < -273.15) 
            { Console.Write("Температура должна быть выше абсолютного нуля\n");
                return;
            }
            double temperatureInF;
            temperatureInF = (s * 1.8) + 32;
            Console.Write("{0:F4}\n", temperatureInF);

        }
    }
}
