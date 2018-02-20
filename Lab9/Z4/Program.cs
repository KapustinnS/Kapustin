using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = int.Parse(Console.ReadLine());
            if (!File.Exists("../../task4642/test" + n + ".txt"))
            {
                Console.Write("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader("../../task4642/test" + n + ".txt");
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }
            String b = "";
            int x = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String[] a = line.Split(' ');
                int L = a.Length;
                i = 0;
                while (i < L)
                {
                    if (a[i] != b)
                    {
                        x++;
                    }
                    i++;
                }
                Console.Write(x + " ");
            }
        }
    }
}