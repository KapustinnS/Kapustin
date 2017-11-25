using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = 0;
                while (b <= a)
                {
                    s += a;
                    a--;
                }
                while (a <= b)
                {
                    s += a;
                    a++;
                }
            Console.WriteLine(s);
        }
    }
}
