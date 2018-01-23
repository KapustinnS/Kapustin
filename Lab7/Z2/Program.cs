using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "abcdefwxyz";
            string x = Console.ReadLine();
            int i = data.IndexOf(x); //ячейка массива
            if ( i < 0)
            {
                Console.WriteLine("Значение отсутствует в строке");
            }
            else
            {
                int result = data.Length - i - 1;
                Console.WriteLine(result);
            }
        }
    }
}
