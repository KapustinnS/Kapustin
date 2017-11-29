using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sum = 0;
            double count = 1;
            if (a <= 0)
            {
                Console.WriteLine("Значение A должно быть положительным");
                return;
            }
            else
            {
                while(count <= a)
                {
                    sum += 1 / count;
                    count++;
                }
            }
            Console.WriteLine("{0:F4}", sum);
        }
    }
}