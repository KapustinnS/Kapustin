using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            str = Console.ReadLine();
            double x;
            x = double.Parse(str);
            double result;
            result = x + 7;
            Console.Write("{0:f4}", result);
        }
    }
}
