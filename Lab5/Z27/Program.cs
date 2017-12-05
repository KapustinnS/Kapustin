using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z27
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a < -10 || a > 100)
            {
                Console.WriteLine("Значение A должно быть в интервале [-10, 100]");
                return;
            }
            if ((a % 10 == 3) && (a != 13))
            {
                Console.WriteLine(a + "'ий");
                return;
            }
            if ((a % 10 == 2 || a % 10 == 6 || a % 10 == 7 || a % 10 == 8 || a % 10 == 0 || a % 10 == 40) && (a != 12) && (a != 16) && (a != 17) && (a != 18))
            {
                Console.WriteLine(a + "'ой");
                return;
            }
            if (a % 10 == 1 || a % 10 == 4 || a % 10 == 5 || a % 10 == 9 || a % 10 == 10 || a == 100 || a == -10 || a == 12 || a == 13 || a == 16 || a == 17 || a == 18)
            {
                Console.WriteLine(a + "'ый");
                return;
            }
            }
        }
    }