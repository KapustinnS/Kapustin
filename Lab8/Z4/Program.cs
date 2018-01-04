using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();
            int i = 10;
            string[] arr = d.Split(' ');
            if (b < 0 || arr.Length <= b)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива]");
                return;
            }
            if (e < 0 || arr.Length <= e)
            {
                Console.WriteLine("Число E должно быть в интервале [0, размер массива]");
                return;
            }
            while (b <= e)
            {
                Console.Write(arr[b] + " ");
                b++;
            }
        }
    }
}