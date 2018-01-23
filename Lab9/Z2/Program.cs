using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string filename = "../../task4488/test" + a + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader;
            reader = new StreamReader(filename);
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            int c = 0;
            string line = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                c++;
            }
            Console.Write(line + " " + c);
            reader.Close();
        }
    }
}