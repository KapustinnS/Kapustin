using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int k;
            k = 0;
            if (a < -100 || a > 500)
            {
                Console.WriteLine("Значение A должно быть в интервале [-100, 500]");
                return;
            }
            while (a <= 500)
            {
                k += a;
                a++;
            }
            Console.WriteLine(k);
        }
    }
}