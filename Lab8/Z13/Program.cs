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
            string s1 = Console.ReadLine();
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine();
                return;
            }
            string[] a1 = s1.Split(' ');
            int i = 0;
            int j = 0;
            int c = 0;
            while (j < a1.Length)
            {
                i = j + 1;
                while (i < a1.Length)
                {
                    if (a1[j] == a1[i])
                    {
                        c++;
                    }
                    i++;
                }
                j++;
            }
            if (c > 0)
            {
                Console.WriteLine("Повторения есть");
            }
            else
            {
                Console.WriteLine("Повторений нет");
            }
        }
    }
}