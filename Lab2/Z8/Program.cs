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
            string a;
            a = Console.ReadLine();
            int z;
            z = int.Parse(a); 
            if (z <=0)
            {
                Console.Write("Значение z должно быть");
                    return;
            }
            a = Console.ReadLine();
            int c;
            c = int.Parse(a);
            if (c <=0)
            {
                Console.Write("Значение c должно быть");
                return;
            }
            int totalInM, partInCm;
            totalInM = (z * 100) / c;
            partInCm = z * 100 % c;
            Console.WriteLine("{0} шт и {1} см", totalInM, partInCm);
        }
    }
}
