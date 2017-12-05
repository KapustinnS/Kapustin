using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = 30;
            int b = 40;
            while (a <= b)
            {
                if (x <= 30)
                {
                    Console.WriteLine(x+"+");
                    x++;
                }
                else
                {
                    if (x >= 40)
                    {
                        Console.WriteLine(x + "-");
                        x++;
                    }
                }
            }
        }
    }
}
