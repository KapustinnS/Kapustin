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
            string date = Console.ReadLine();
            int l = 0;
            if (string.IsNullOrWhiteSpace(date))
            {
                return;
            }
            string[] arr = date.Split(' ');
            while ( l < arr.Length)
            {
                Console.WriteLine(arr[l] + " " + l);
                l++;
           }
        }
    }
}