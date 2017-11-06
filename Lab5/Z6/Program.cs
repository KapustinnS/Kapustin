using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
{
    class Program
    {
        static void Main(string[] args)
        {
            double KmH = double.Parse(Console.ReadLine());
            double MS = double.Parse(Console.ReadLine());
            double a;
            if (MS < 0)
            {
                Console.Write("Значение velocityInMS должно быть неотрицательным\n");
                return;
            }
            if (KmH < 0)
            {
                Console.Write("Значение velocityInKmH должно быть неотрицательным\n");
                return;
            }
            a = KmH * 1000 / 3600;
            if (a > MS)
            {
                Console.Write("{0:F2} м/с меньше {1:F2} км/ч\n", MS,KmH);

            }
            else
            {
                Console.Write("{0:F2} км/ч меньше {1:F2} м/c\n", KmH,MS);
            }
        }
    }
}
