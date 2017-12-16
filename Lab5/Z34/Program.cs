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
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if (w <= 0)
            {
                Console.WriteLine("Значение W должно быть положительным");
                return;
            }
            if (h <= 0)
            {
                Console.WriteLine("Значение H должно быть положительным");
                return;
            }
            if (c <= 0)
            {
                Console.WriteLine("Значение C должно быть положительным");
                return;
            }
            if (d <= 0)
            {
                Console.WriteLine("Значение D должно быть положительным");
                return;
            }
            int s1 = (h / c) * (w / d);
            int s2 = (w / c) * (h / d);
            if (s1 > s2)
            {
                Console.WriteLine("{0} при С вдоль Н", s1);
            }
            else
            {
                Console.WriteLine("{0} при С вдоль W", s2);
            }
        }
    }
}