using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z18
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            while (sum <= 1000)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}