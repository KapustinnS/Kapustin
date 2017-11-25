using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z29
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Координата X должна быть неотрицательной");
                return;
            }
            if (y < 0)
            {
                Console.WriteLine("Координата Y должна быть неотрицательной");
                return;
            }
            if (x >= 100 && x <= 190 && y >= 100 && y <= 170)
            {
                Console.WriteLine("Точка внутри");
            }
            else
            {
                Console.WriteLine("Точка снаружи");
            }
        }
    }
}