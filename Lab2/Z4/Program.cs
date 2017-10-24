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
            string b;
            b = Console.ReadLine();
            double z;
            z = double.Parse(b);
            double circumference;
            circumference = Math.PI * 2 * z;
            Console.Write("{0:F4}", circumference);
        }
    }
}
