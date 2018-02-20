using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = int.Parse(Console.ReadLine());
            if (!File.Exists("..\\..\\task5537\\test" + n + ".txt"))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader("..\\..\\task5537\\test" + n + ".txt");
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            int a = 0;
            int J = 0;
            int x = 0;
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                int L = line.Length;
                if (L > 4)
                {
                    Console.WriteLine("Запись длиннее  четырёх символов ");
                    return;
                }
                if (L < 4)
                {
                    Console.WriteLine("Запись короче  четырёх символов ");
                    return;
                }
                i = 0;
                x = 0;
                a = 0;
                while (i + 1 < L)
                {

                    x = 0;
                    if (line[i] == line[i + 1])
                    {
                        x++;
                        if (x == 1 && a < 1)
                        {
                            J = J + 1;
                            x = 0;
                            a++;
                        }
                    }
                    i++;
                }
            }
            Console.WriteLine(J);
        }
    }
}