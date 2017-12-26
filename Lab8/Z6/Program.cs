using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int i = 0;
            string x;
            string[] arr = a.Split(' ');
          

            arr[4] = arr[3];
            arr[3] = arr[2];
            arr[2] = arr[1];
            x = arr[1];
            x = arr[5];
            arr[5] = arr[4];
            while (i < arr.Length)
            {
                Console.Write(arr[i] + " ");
                i++;
            }
        }
    }
}
