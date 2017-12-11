using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z32
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int r = 0;
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
            while (r < h)
            {
                i = 0;
                while (i < w)
                {
                    Console.Write(s);
                    i++;
                }
                r++;
                Console.WriteLine();
            }
        }
    }
}