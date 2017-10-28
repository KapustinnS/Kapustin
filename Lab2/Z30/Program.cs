using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z30
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = Console.ReadLine();
            double a = double.Parse(w);
            w = Console.ReadLine();
            double b = double.Parse(w);
            double result;
            result = Math.Sin(a*Math.PI/180)*Math.Cos(b*Math.PI/180)+Math.Sin(b*Math.PI/180)*Math.Cos(a*Math.PI/180);
            Console.Write("{0:F4}\n", result);
        }
    }
}