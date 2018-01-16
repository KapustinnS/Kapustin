using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int i = 0;
            string a1 = Console.ReadLine();
            string[] a = a1.Split(' ');
            if (string.IsNullOrWhiteSpace(a1))
            {
                return;
            }
            int[] b = new int[a.Length];
            while (i < a.Length)
            {
                b[i] = m * int.Parse(a[i]);
                Console.Write(b[i] + " ");
                i++;
            }
        }
    }
}