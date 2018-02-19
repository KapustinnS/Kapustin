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
            String a, b, c;
            int x, y, v;
            a = Console.ReadLine();
            b = Console.ReadLine();
            string Q = "abcdefwxyz";
            x = Q.IndexOf(a);
            y = Q.IndexOf(b);
            if (x < y)
            {
                v = y - x;
                x = x + 1;
                v = v - 1;
                c = Q.Substring(x, v);
            }
            else
            {
                v = x - y;
                y = y + 1;
                v = v - 1;
                c = Q.Substring(y, v);
            }
            Console.Write(c);
        }
    }
}