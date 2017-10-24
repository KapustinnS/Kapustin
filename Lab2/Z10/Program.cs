using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z10
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            double b;
            b = int.Parse(a);
            double z;
            z = Math.Sin(b * Math.PI / 180);
            Console.Write("{0:F4}",z);
        }
    }
}
