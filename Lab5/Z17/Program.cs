using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z17
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            if (P == 0)
            {
                Console.Write("Значение P дожно быть не равно нулю\n");
                return;
            }
            double z, a;
            a = M % P;
            if (a == 0)
            {
                z = M / P;
                Console.Write(z);
            }
            else
            {
                Console.Write("M не делится нацело на P\n");
            }
        }
    }
}