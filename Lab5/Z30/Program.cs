using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z30
{
    class Program
    {
        static void Main(string[] args)
        {
            int Xt = int.Parse(Console.ReadLine());
            int Yt = int.Parse(Console.ReadLine());
            int Xp1 = int.Parse(Console.ReadLine());
            int Yp1 = int.Parse(Console.ReadLine());
            int Xp2 = int.Parse(Console.ReadLine());
            int Yp2 = int.Parse(Console.ReadLine());
            if (Xt < 0)
            {
                Console.WriteLine("Координата X должна быть неотрицательной");
                return;
            }
            int x, y;
            x = (Xt - Xp1) * (Xp2 - Xp1);
            y = (Yt - Yp1) * (Yp2 - Yp1);
            if (x == y)
            {
                Console.WriteLine("Точка принадлежит прямой");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит прямой");
            }
        }
    }
}