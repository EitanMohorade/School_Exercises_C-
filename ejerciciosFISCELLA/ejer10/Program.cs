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
            Baraja barja = new Baraja();
            barja.barajar();

            for(var i = 0; i < barja.baraja.Count; i++)
            {
                Console.WriteLine(barja.siguienteCarta());
                //Console.WriteLine(barja.baraja[i]);
            }
            Console.WriteLine("\n"+barja.cartasDisponibles());
            
                
            
            Console.ReadKey();
        }
    }
}
