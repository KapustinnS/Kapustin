using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            String User, Password, Host, Port, Database;
            User = Console.ReadLine();
            Password = Console.ReadLine();
            Host = Console.ReadLine();
            Port = Console.ReadLine();
            Database = Console.ReadLine();
            Console.WriteLine(" User ID=\"{0}\"; Password=\"{1}\";\n" +
                " Host=\"{2}\"; Port=\"{3}\"; Database=\"{4}\";", User, Password, Host, Port, Database);
        }
    }
}
