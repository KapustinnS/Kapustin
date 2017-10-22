using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            String b;
            b = Console.ReadLine();
            Console.Write("SELECT first name, last name, group");
            Console.Write("From students WHERE id = '");
            Console.Write(b);
            Console.Write("';");
        }
    }
}
