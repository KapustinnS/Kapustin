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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Значение A должно быть не больше значения B");
                return;
            }
            while (b >= a)
            {
                Console.Write(b+" ");
                b = b - 1;
            }
        }
    }
}