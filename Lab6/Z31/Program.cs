using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z31
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int i = 0;
            if (w < 0 || w > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале[0, 20]");
                return;
            }
            else
                while (i < w)
                {
                    Console.Write("0");
                    i++;
                }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("1");
                i++;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("2");
                i++;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("3");
                i++;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("4");
                i++;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("5");
                i++;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("6");
                i++;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("7");
                i++;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("8");
                i++;
            }
            Console.WriteLine();
            i = 0;
            while (i < w)
            {
                Console.Write("9");
                i++;
            }
            Console.WriteLine();
        }
    }
}
