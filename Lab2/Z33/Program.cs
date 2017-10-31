using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z33
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double x = double.Parse(a);
            double r;
            r = 6350;
            double z;
            if (x < 0)
            {
                Console.Write("Высота над уровнем Земли должна быть неотрицательна\n");
                    return; }
            z = Math.Sqrt(Math.Pow(r + x, 2) - Math.Pow(r, 2));
            Console.Write("{0:F4}\n", z);
        }
    }
}
