using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices raices = new Raices(10, 40, 2);
            raices.obtenerRaices();
            double a = ((40 * -1) - Math.Sqrt(((Math.Pow(40, 2)) - (4 * 10 * 2)))) / (2 * 10);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
