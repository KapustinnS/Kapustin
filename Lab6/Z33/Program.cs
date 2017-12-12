using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z33
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int i = 0;
            int w1 = w - 2;
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (w == 0)
            {
                return;
            }
            Console.Write("+");
            while (i < w1)
            {
                Console.Write("-");
                i++;
            }
            Console.WriteLine("+");
            Console.Write("|");
            w1 = w - 2;
            i = 0;
            while (i < w1)
            {
                Console.Write(".");
                i++;
            }
            Console.WriteLine("|");
            Console.Write("+");
            w1 = w - 2;
            i = 0;
            while (i < w1)
            {
                Console.Write("-");
                i++;
            }
            Console.Write("+");
        }
    }
}