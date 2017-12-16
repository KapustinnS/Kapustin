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
            int b1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            if (a1 > b1 || a2 > b2)
            {
                Console.WriteLine("Значение A должно быть меньше значения B");
                return;
            }
            if (a2 > b1 || b2 < a1)
            {
                Console.WriteLine("не пересекаются");
            }
            else
            {
                if (a1 < a2 && a2 < b1 && b1 < b2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", a2,b1);
                    return;
                }
                if (a1 < a2 && a2 < b1 && b1 < b2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", a2,b2);
                    return;
                }
                if (a1 > a2 && a2 < b1 && b1 < b2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", a1,b1);
                        return;
                }
                if ( a1 > a2 && a2 < b1 && b1 > b2)
                {
                    Console.WriteLine("Пересекаются ({0};{1})", a1,b2);
                }
            }
        }
    }
}