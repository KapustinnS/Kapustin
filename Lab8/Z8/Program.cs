using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] s1 = s.Split(' ');
            int i = 0;
            while (i < s1.Length)
            {
                Console.Write(s1[s1.Length - i - 1] + " ");
                i++;
            }
        }
    }
}
