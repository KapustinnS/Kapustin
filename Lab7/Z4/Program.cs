using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "abcdacadbacdaabaadc";
            string a = Console.ReadLine();
            if (a.Length !=2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
                return;
            }
            int i = 0;
            int b = 0;
            int x = 0;
            while (i < 19)
            {
                x = data.IndexOf(a, b);
                if (b == x)
                {
                    Console.Write(x + " ");
                }
                i++;
                b++;
            }
        }
    }
}