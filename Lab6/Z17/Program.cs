using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 1;
            while (a != 0)
            {
                sum = sum + a;
                count++;
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма чисел:" +sum+ "Количество чисел:" +count);
        }
    }
}