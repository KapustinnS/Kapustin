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
            int a = int.Parse(Console.ReadLine());
            a = 17;
            int b;
            b = 47;
            while (a < b)
            {
                Console.Write(a+" ");
                a = a + 1;
            }
        }
    }
}