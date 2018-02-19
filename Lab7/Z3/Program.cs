using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "abcdefwxyz";
            string CA = Console.ReadLine();
            string CB = Console.ReadLine();
            int m = 0;
            int i = data.IndexOf(CA);
            int n = data.IndexOf(CB);
            if (i == -1)
            {
                Console.WriteLine("Значение CA отсутствует в строке");
                return;
            }
            if (n == -1)
            {
                Console.WriteLine("Значение CB отсутствует в строке");
                return;
            }
            if (i > n)
            {
                m = i - n - 1;
                Console.WriteLine(m);
            }
            else
            {
                m = n - i - 1;
                Console.WriteLine(m);
            }
        }
    }
}