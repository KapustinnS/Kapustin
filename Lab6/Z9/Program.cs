using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;
            int s;
            s = 1;
            while (a <= 9)
            {
                s = a * 7;
                Console.WriteLine("{0} x 7 = {1}",a,s);
                a++;
            }
        }
    }
}
