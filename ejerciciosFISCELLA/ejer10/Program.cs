using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Baraja baraja = new Baraja();
            baraja.barajar();
            foreach(string barja in baraja.baraja)
            {
                Console.WriteLine(baraja.baraja[cont]);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
