﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            if (x < 5 && x > -3)
            {
                Console.Write(x + " ");
            }
            if (y < 5 && y > -3)
            {
                Console.Write(y + " ");
            }
            if (z < 5 && z < -3)
            {
                Console.Write(z);
            }
        }
    }
}
