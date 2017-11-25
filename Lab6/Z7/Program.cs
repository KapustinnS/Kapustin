using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a <= b)
            {
                Console.Write(a + " ");
                a++;
            }
            while (a >= b)
            {
                Console.Write(a + " ");
                a--;
            }
        }
    }
}