using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine("0");
                return;
            }
            string[] a1 = s1.Split(' ');
            int a = 0;
            int s = 0;
            int i = 0;
            while (i < a1.Length)
            {
                s += int.Parse(a1[i]);
                i++;
            }
            a = s / a1.Length;
            Console.WriteLine("Срнеднее арифметическое: {0}", a);
        }
    }
}
