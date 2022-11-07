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
            List<string> usuario1 = new List<string>();
            Baraja barja = new Baraja();
            barja.barajar();
            Console.WriteLine(barja.baraja.Count);
            for(var i = 8; i < barja.baraja.Count; i++)
            {
                barja.siguienteCarta();
            }
            

            barja.darCartas(4, usuario1);
            for (int i = 0; i < usuario1.Count; i++)
            {
                Console.WriteLine("el usuario1 tiene: "+usuario1[i]);
            }
            barja.cartasDisponibles();
            //barja.cartasMonto();
            barja.mostrarBaraja();

            Console.ReadKey();
        }
    }
}
