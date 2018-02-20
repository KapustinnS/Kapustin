using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int i = 0;
            string name = "../../task4954/test" + a + ".txt";
            string b = Console.ReadLine();
            if (!File.Exists(name))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            using (StreamReader reader = new StreamReader(name))
            {
                if (reader.EndOfStream)
                {
                    Console.WriteLine("Файл пуст");
                    return;
                }
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.IndexOf(b) != -1)
                    {
                        i++;
                    }
                }
                Console.WriteLine(i);
            }
        }
    }
}