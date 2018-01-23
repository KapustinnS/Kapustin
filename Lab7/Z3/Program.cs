using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "abcdefwxyz";
            string CA = Console.ReadLine();
            string CB = Console.ReadLine();
            int i = data.IndexOf(CA);
            int n = data.IndexOf(CB);
            if (i < 0)
            {
                Console.WriteLine("Значение CA отсутствует в строке");
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("Значение CB отсутствует в строке");
                return;
            }
            int result = i - n -1;
            Console.WriteLine(result);
        }
    }
}