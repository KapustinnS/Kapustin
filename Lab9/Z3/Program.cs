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
            string b = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int a1 = 0;
            string filename = "../../task4642/test" + a + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            int c = 0;
            StreamReader reader;
            reader = new StreamReader(filename);
            string line = reader.ReadLine();
            //if (c < a1)
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        Console.Write(b);
            //        c++;
            //    }
            //}
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                c++;
            }
            Console.Write(line);
            reader.Close();
        }
    }
}
