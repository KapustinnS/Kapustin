using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
                while (a <= b)
                {
                    Console.Write(a + " ");
                    a = a + 1;
                }
                while (a >= b)
                {
                    Console.Write(b + " ");
                    b = b + 1;
                }
            }
        }
    }