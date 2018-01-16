using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Данные сверху отсутствуют");
                return;
            }
            string s2 = Console.ReadLine();
            if (string.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Данные слева отсутствуют");
                return;
            }
            string[] a1 = s1.Split(' ');
            string[] a2 = s2.Split(' ');
            int i = 0;
            int j = 0;
            Console.WriteLine("  " + s1.Replace("_", ""));
            while(j < a2.Length)
            {
                i = 0;
                Console.Write(a2[j] + " ");
                while (i < a1.Length)
                {
                    if (a2[j] == a1[i])
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    i++;
                }
                Console.WriteLine("|");
                j++;
            }
            Console.Write(" ");
            i = 0;
            while (i < (s1.Length+2))
            {
                Console.Write("-");
                i++;
            }
            Console.Write(" ");
        }
    }
}