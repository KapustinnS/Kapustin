using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int right = 0;
            int left = 0;
            while (a <= 83 || a >= 199)
            {
                a = int.Parse(Console.ReadLine());

                if (a <= 83 || a >= 199)
                {
                    if (a >= 199)
                    {
                        right++;
                    }
                    if (a <= 83)
                    {
                        left++;
                    }
                }
            }
            Console.WriteLine("Количество слева: " + left + ",количества справа: " + right);
        }
    }
}