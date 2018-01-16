using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z17
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine();
                return;
            }
            int b = int.Parse(Console.ReadLine());
            string[] a1 = s1.Split(' ');
            if (b < 0 || b > a1.Length - 1)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива)");
            }
            else
            {
                int c = 0;
                int b1 = int.Parse(a1[b]);
                int i = 0;
                while (i < b)
                {
                    int a2 = int.Parse(a1[i]);
                    i++;
                    if (a2 < b1)
                    {
                        c++;
                    }
                }
                while (i < a1.Length)
                    i = 0;
                {
                    i = b + 1;
                    int a2 = int.Parse(a1[i]);
                    if (a2 < b1)
                    {
                        c++;
                    }
                }
                Console.WriteLine(c);
            }
        }
    }
}