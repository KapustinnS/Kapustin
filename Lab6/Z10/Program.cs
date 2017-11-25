using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int v = 0;
            while ( a <= b)
            {
                v += a;
                Console.Write(v + " ");
                a++;
            }
            Console.WriteLine();
            Console.WriteLine("Ответ:" + v);
        }
    }
}
