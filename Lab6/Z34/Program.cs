using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z34
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
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
            if (w == 0)
            {
                return;
            }
            if (h == 0)
            {
                return;
            }
            Console.Write(" ");

            while (i < w)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();
            while (j < h)
            {
                i = 0;
                Console.Write(j);
                while (i < w)
                {

                    Console.Write(".");
                    i++;
                }

                Console.Write("|");
                Console.WriteLine();
                j++;

            }
            i = 0;
            Console.Write(" ");
            while (i < w)
            {
                Console.Write("_");
                i++;
            }
        }
    }
}

