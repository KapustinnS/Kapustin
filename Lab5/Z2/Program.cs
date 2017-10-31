using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = double.Parse(Console.ReadLine());
            double q = double.Parse(Console.ReadLine());
            if (q < p)
            {
                Console.Write("Максимальное " + p + ", Минимальное " + q);
            }
            else
            {
                Console.Write("Максимальное " + q + ", Минимальное " + p);
            }
        }
    }
}
