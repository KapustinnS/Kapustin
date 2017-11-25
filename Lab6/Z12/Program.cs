using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int k = 0;
            if (a < -10 || a > 10000)
            {
                Console.WriteLine("Значение A должно быть в интервале [-10,10000]");
            }
            else
            {
                while (a >= -10)
                {
                    k += a;
                    a--;
                }
                Console.WriteLine(k);
            }
        }
    }
}
