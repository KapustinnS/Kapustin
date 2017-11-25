using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 453;
            int b;
            b = 1;
            int z;
            z = 1;
            while (b <= 20)
            {
                z = a * b;
                Console.WriteLine("{0}    {1} ", b,z);
                b ++;
            }
        }
    }
}