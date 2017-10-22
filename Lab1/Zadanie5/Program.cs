using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b; 
            a = Console.ReadLine();
            b = Console.ReadLine();
            Console.Write(" ");
            Console.Write(b);
            Console.Write(" ");
            Console.Write(a);
            String str = "абв";
            String input = "где";
            String temp = str + "з";
            str = temp;
            input = "и" + str;

        }
    }
}
