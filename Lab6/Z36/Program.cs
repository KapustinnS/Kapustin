using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string i = "";
            string j = ".";
            if (a > b)
            {
                while (b < a)
                {
                    if (b % 2 != 0)
                    {
                        Console.Write(i);
                        Console.WriteLine(b);
                        i += j;
                    }
                    b++;
                }
            }
            while (a <= b)
            {
                if (a % 2 != 0)
                {
                    Console.Write(i);
                    Console.WriteLine(a);
                    i += j;
                }
                a++;
            }
        }
    }
}
