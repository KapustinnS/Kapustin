using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12
{
    class Program
    {
        static void Main(string[] args)
        {
            String x = Console.ReadLine();
            if (x == "a")
            {
                Console.Write("a+\nb\nc\nd\ne\nf\ng\nh\n");
            }
            if (x == "d")
            {
                Console.Write("a\nb\nc\nd+\ne\nf\ng\nh\n");
            }
            if (x == "h")
            {
                Console.Write("a\nb\nc\nd\ne\nf\ng\nh+\n");
            }
            if (x == "i")
            {
                Console.Write("a\nb\nc\nd\ne\nf\ng\nh\n");
            }
            if (x == "c")
            {
                Console.Write("a\nb\nc+\nd\ne\nf\ng\nh\n");
            }
            if (x == "b")
            {
                Console.Write("a\nb+\nc\nd\ne\nf\ng\nh\n");
            }
            if (x == "e")
            {
                Console.Write("a\nb\nc\nd\ne+\nf\ng\nh\n");
            }
            if (x == "f")
            {
                Console.Write("a\nb\nc\nd\ne\nf+\ng\nh\n");
            }
            if (x == "g")
            {
                Console.Write("a\nb\nc\nd\ne\nf\ng\nh\n");
            }
        }
    }
}
