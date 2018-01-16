using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z16
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Данные слева отсутсвуют");
                return;
            }
            string s2 = Console.ReadLine();
            if (string.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Данные справа отсутствуют");
                return;
            }
            string[] a1 = s1.Split(' ');
            string[] a2 = s2.Split(' ');
            if (a1.Length != a2.Length)
            {
                Console.WriteLine("Размеры массивов должны быть одинаковы");
            }
            else
            {
                int i = 0;
                while (i < a1.Length)
                {
                    Console.Write(int.Parse(a1[i]) * int.Parse(a2[i]) + " ");
                    i++;
                }
            }
        }
    }
}
