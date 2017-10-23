using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            String CX, CY, r, fill;
            CX = Console.ReadLine();
            CY = Console.ReadLine();
            r = Console.ReadLine();
            fill = Console.ReadLine();
            Console.WriteLine(" <circle cx =\"{0}\", cy=\"{1}\",\n" +
                " r=\"{2}\", fill=\"{3}\"/>", CX,CY,r,fill);
        }
    }
}
