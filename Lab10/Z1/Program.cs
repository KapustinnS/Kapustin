using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename1 = "../../12.txt";
            string filename = "1.html";
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine("<!DOCTYRE html>\n" +
               "<html>\n" +
               "<head>\n" +
               "    <meta charset=\"utf-8\"/>\n" +
               "</head>\n" +
               "<body>\n" +
               "    <h1>Мой первый векторный рисунок</h1>\n" +
               "" +
               "    <svg width=\"800\" height=\"600\">\n" +
               "        <circle cx=" + a +" cy=" + b + " r=" + c + " stroke=\"green\"\n" +
               "                stroke-width=" + d + " fill=\"yellow\">\n" +
               "    </svg>\n" +
               "</body>\n" +
               "</html>");
            writer.Close();
        }
    }
}
