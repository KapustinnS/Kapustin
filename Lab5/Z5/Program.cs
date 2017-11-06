using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            double dInKm = double.Parse(Console.ReadLine());
            double dInFeet = double.Parse(Console.ReadLine());
            if (dInKm < 0 )
            {
                Console.Write("Значение distanceInKm должно быть не отрицательным\n");
                return;
            }
            if (dInFeet < 0)
            {
                Console.Write("Значение distanceInFeet должно быть не отрицательным\n");
                return;
            }
            if (dInKm * 1000 > dInFeet * 0.305)
            {
                Console.Write("Расстояние в футах меньше\n");
            }
            else
            {
                Console.Write("Расстояние в километрах меньше\n");
            }
        }
    }
}
