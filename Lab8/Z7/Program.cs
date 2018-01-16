using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = 0;
            string t = Console.ReadLine();
            string x;
            int i = 0;
            string[] arr = t.Split(' ');
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