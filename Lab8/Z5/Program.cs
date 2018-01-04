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
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int i = 0;
            string x;
            string d = Console.ReadLine();
            string[] arr = d.Split(' ');
            if (p < 0 || arr.Length <= p)
            {
                Console.WriteLine("Число P должно быть в интервале [0,размер массива]");
                return;
            }
            if (q < 0 || arr.Length <= q)
            {
                Console.WriteLine("Число Q должно быть в интервале [0,размер массива]");
                return;
            }
            x = arr[p];
            arr[p] = arr[q];
            arr[q] = x;
            while (i < arr.Length)
            {
                Console.Write(arr[i] + " ");
                i++;
            }
        }
    }
}
