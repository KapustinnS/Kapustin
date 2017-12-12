using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z31
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            if (w < 0 || w > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале[0, 20]");
                return;
            }
            while (j < 10)
            {
                while (i < w)
                {
                    Console.Write(j);
                    i++;
                }
                Console.WriteLine();
                i = 0;
                j++;
            }
        }
    }
}
