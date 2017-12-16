using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z32
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int h1 = int.Parse(Console.ReadLine());
            int w1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int w2 = int.Parse(Console.ReadLine());
            int z1, z2, k1, k2, w3, h3;
            z1 = x1 + w1;
            z2 = x2 + w2;
            k1 = y1 + h1;
            k2 = y2 + h2;
            if (h1 <= 0 || h2 <= 0)
            {
                Console.WriteLine("Высота должна быть положительна");
                return;
            }
            if (x2 >= z1 || y2 >= k1 || z2 <= x1 || k2 <= y1)
            {
                Console.WriteLine("Не пересекаются");
            }
            else
            {
                if (x1 <= x2 && x2 < z1 && z1 <= z2)
                {
                    if (y1 <= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z1 - x2;
                        h3 = k1 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y2, w3, h3);
                        return;
                    }
                    if (y1 <= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z1 - x2;
                        h3 = k2 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y2, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z1 - x2;
                        h3 = k1 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y1, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z1 - x2;
                        h3 = k2 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y1, w3, h3);
                        return;
                    }
                }
                if (x1 <= x2 && x2 < z1 && z1 >= z2)
                {
                    if (y1 <= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z2 - x2;
                        h3 = k1 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y2, w3, h3);
                        return;
                    }
                    if (y1 <= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z2 - x2;
                        h3 = k2 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y2, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z2 - x2;
                        h3 = k1 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y1, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z2 - x2;
                        h3 = k2 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x2, y1, w3, h3);
                        return;
                    }
                }
                if (x1 >= x2 && x2 < z1 && z1 <= z2)
                {
                    if (y1 < y2 && y2 < k1 && k1 < k2)
                    {
                        w3 = z1 - x1;
                        h3 = k1 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y2, w3, h3);
                        return;
                    }
                    if (y1 <= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z1 - x1;
                        h3 = k2 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y2, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z1 - x1;
                        h3 = k1 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y1, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z1 - x1;
                        h3 = k2 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y1, w3, h3);
                        return;
                    }
                }
                if (x1 >= x2 && x2 < z1 && z1 >= z2)
                {
                    if (y1 <= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z2 - x1;
                        h3 = k1 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y2, w3, h3);
                        return;
                    }
                    if (y1 <= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z2 - x1;
                        h3 = k2 - y2;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y2, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 <= k2)
                    {
                        w3 = z2 - x1;
                        h3 = k1 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y1, w3, h3);
                        return;
                    }
                    if (y1 >= y2 && y2 < k1 && k1 >= k2)
                    {
                        w3 = z2 - x1;
                        h3 = k2 - y1;
                        Console.WriteLine("\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}", x1, y1, w3, h3);
                        return;
                    }
                }
            }
        }
    }
}