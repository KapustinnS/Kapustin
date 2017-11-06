using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a<0)
            {
                a = a * -1;
            }
            else
            {
                a = a;
            }
            Console.Write("{0:F0}\n", a);
        }
    }
}
