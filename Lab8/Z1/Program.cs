using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string date = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(date))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }
            string[] arr = date.Split(' ');
            if (a < 0 || arr.Length <= a)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива]");
                return;
            }
            Console.WriteLine(arr[a]);
        }
    }
}
