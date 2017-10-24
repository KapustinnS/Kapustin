using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = Console.ReadLine();
            int aInitial;
            aInitial = int.Parse(a);
            int aRemainder;
            aRemainder = aInitial % 360;
            Console.Write("{0}", aRemainder);
        }
    }
}
