using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z25
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int i = 0;
            if (y < 0 || y > 15)
            {
                Console.WriteLine("Значение Y должно быть в интервале [0, 15]");
                return;
            }
            while (i != 15)
            {
                if (i < y)
                {
                    Console.Write("#");
                }

                else
                {
                    Console.Write(".");
                }
                i++;
            }
        }
    }
}
