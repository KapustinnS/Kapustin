﻿using System;
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
            double k = double.Parse(Console.ReadLine());
            if (k > 0)
            {
                k = Math.Sqrt(k);
                Console.Write(k);
                Console.Write("\n");
            }
            else
            { 
                k = k * k;
                Console.Write(k);
                Console.Write("\n");
            }
        }
    }
}
