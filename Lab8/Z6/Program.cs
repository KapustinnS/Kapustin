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
            if (string.IsNullOrWhiteSpace(a))
            {
                return;
            }
            // x = arr[5];
            //  arr[5] = arr[4];
            // arr[4] = arr[3];
            // arr[3] = arr[2];
            // arr[2] = arr[1];
            // arr[1] = arr[0];
            //  arr[0] = x;
            int c = 5;
            int d = 6;
            //x = arr[c];

            //c--;
            //d--;
            //arr[d] = arr[c];

            //c--;
            //d--;
            //arr[d] = arr[c];

            //c--;
            //d--;
            //arr[d] = arr[c];

            //c--;
            //d--;
            //arr[d] = arr[c];

            //c--;
            //d--;
            //arr[d] = arr[c];

            //arr[0] = x;
            c = arr.Length - 1;
            d = arr.Length;
            x = arr[c];
            while (c > 0)
            {
                c--;
                d--;
                arr[d] = arr[c];

            }
            arr[0] = x;
            while (i < arr.Length)
            {
                Console.Write(arr[i] + " ");
                i++;
            }
        }
    }
}