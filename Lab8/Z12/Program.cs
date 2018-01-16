using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12
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
            int c = 0;
            while (j < a1.Length)
            {
                i = 0;
                while (i < a2.Length)
                {
                    if (a1[j] == a2[i])
                    {
                        c++;
                    }
                    i++;
                }
                j++;
            }
            Console.WriteLine("Повторений: {0}", c);
        }
    }
}
