using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z37
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            string a = "", b = "+", c = "#";
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            while (j <= h)
            {
                while (i <= w)
                {
                    Console.Write(b);
                    i++;
                }
                w--;
                i = 0;
                Console.Write(a);
                Console.WriteLine();
                a += c;
                j++;
            }
        }
    }
}