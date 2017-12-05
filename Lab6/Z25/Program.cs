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
            if (i >= 15)
            {
                Console.WriteLine("Значение Y должно быть в интервале [0, 15]");
                return;
            }
            while (i <= 15)
            {
                if (i % 15 != 0)
                {
                    Console.Write("#");
                    Console.Write(".");
                    y++;
                }

                else
                {
                    Console.Write(".");
                    y++;
                }

            }
        }
    }
}
