using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z31
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int a3, b3;
            if (a1 > b1 || a2 > b2)
            {
                Console.WriteLine("Значение A должно быть меньше значения B");
                return;
            }
            if ((a1 < a2 && b1 < a2) || (a1 > b2 && b1 > b2))
            {
                Console.WriteLine("не пересекаются");
                return;
            }
            if (a1 < a2)
            {
                a3 = a2;
            }
            else
            {
                a3 = a1;
            }
            if (b1 < b2)
            {
                b3 = b1;
            }
            else
            {
                b3 = b2;
            }
            Console.WriteLine("пересекаются (" + a3 + ";" + b3 + ")");
        }
    }
}