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
            string[] a = { "a", "b", "c", "d", "e", "f", "g", "h" };
            string b = Console.ReadLine();
            int i = 0;
            while (i < a.Length)
            {
                if (a[i] == b)
                {
                    Console.WriteLine(a[i] + "+");
                }
                else
                {
                    Console.WriteLine(a[i]);
                }
                i++;
            }
        }
    }
}
