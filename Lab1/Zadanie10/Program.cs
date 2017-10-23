using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            String a,b;
            a = Console.ReadLine();
            b = Console.ReadLine();
            Console.WriteLine("INSERT INTO points (x,y) VALUES ('{0}','{1}');", a, b);
        }
    }
}
