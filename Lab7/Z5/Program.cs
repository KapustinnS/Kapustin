using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            String c;;
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Значение CA должно быть в интервале [0,длина строки)");
                return;
            }
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 0 || b > 10)
            {
                Console.WriteLine("Значение Cb должно быть в интервале [0,длина строки)");
                return;
            }
            if (b < a)
            {
                Console.WriteLine("Значение CA должно быть меньше CB");
                return;
            }
            b = b - a;
            string Q = "abcdefwxyz";
            c = Q.Substring(a, b + 1);
            Console.Write(c);
        }
    }
}