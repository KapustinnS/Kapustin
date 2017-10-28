using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z21
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            double r1 = double.Parse(x);
            
            x = Console.ReadLine();
            double r2 = double.Parse(x);
            double result;
            if (r1 == 0)
            {
                Console.Write("Значение r1 должно быть не равно нулю\n" +
                  "");
                return;
            }
            if (r2 == 0)
            {
                Console.Write("Значение r2 должно быть не равно нулю\n" +
                  "");
                return;
            }   
            result = (1 / r1) + (1 / r2);
            Console.Write("{0:F4}\n" +
                "", result);
        }
    }
}
