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
            string d = Console.ReadLine();
            int l;
            if (string.IsNullOrWhiteSpace(d))
            {
                return;
            }
            string[] arr = d.Split(' ');
            l = arr.Length - 1;
            while (l >= 0)
            {
                Console.Write(arr[l] + " ");
                l--;
            }
        }
    }
}