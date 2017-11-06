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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ( a == 0 )
            {
                Console.Write("Данное уравнение не является квадратным\n");
                return;
            }
            double z;
            z = Math.Pow(b, 2)- 4 * (a * c);
            if ( z == 0 )
            { Console.Write("Уравнение "+a+"x^2+"+b+"x+"+c+"=0 имеет один корень\n", a,b,c);
                return;
            }
            if ( z > 0 )
            { Console.Write("У уравнения "+a+"x^2+"+b+"x+"+c+"=0 два вещественных корня\n", a,b,c);
                return;
            }
            if ( z < 0 )
            { Console.Write("Вещественных корней уравнения "+a+"x^2+"+b+"x+"+c+"=0 нет\n", a,b,c);
                return;
            }
        }
    }
}