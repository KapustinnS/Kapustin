using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Z6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (!File.Exists("..\\..\\task5847\\test" + n + ".txt"))
            {
                Console.Write("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\task5847\\test" + n + ".txt");
            if (reader.EndOfStream)
            {
                Console.Write("Файл пуст");
                return;
            }
            String A = Console.ReadLine();
            int J = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                int L = line.Length;
                int x = line.IndexOf(A);
                if (x == -1)
                {
                    Console.WriteLine("Указанная буква не найдена");
                    return;
                }
                if (x > 1)
                {
                    Console.WriteLine("В данной строке несколько искомых букв");
                    return;
                }
                J = L - x;
            }
            Console.WriteLine(J - 1);
        }
    }
}