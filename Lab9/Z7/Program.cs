using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Z7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (!File.Exists("..\\..\\task4769\\test" + n + ".txt"))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\task4769\\test" + n + ".txt");
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            String A = Console.ReadLine();
            String B = Console.ReadLine();
            int J = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                int L = line.Length;

                int x1 = line.IndexOf(A);
                int x2 = line.IndexOf(B);
                if (x1 == -1 || x2 == -1)
                {
                    Console.WriteLine("Одна из указанных букв не найдена");
                    return;
                }
                if (x1 == x2)
                {
                    Console.WriteLine("В данной строке несколько искомых букв");
                    return;
                }

                if (x1 > 1)
                {
                    Console.WriteLine("В данной строке несколько искомых значений");
                    return;
                }
                if (x1 > x2)
                {
                    int I = x1 - x2;
                    Console.Write(I - 1);
                    return;
                }
                else
                {
                    int I = x2 - x1;
                    Console.Write(I - 1);
                    return;
                }
            }
            Console.WriteLine(J - 1);
        }
    }
}