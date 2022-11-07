using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    internal class Baraja
    {
        int cont = 0;
        static Random rnd = new Random();
        string[] palo = { "espada", "basto", "oro", "copa" };
        int[] numero = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        public List<string> baraja = new List<string>();
        ///CONSTRUCTORES///
        public Baraja()
        {
            crearBaraja();
        }
        ///METODOS///
        public void crearBaraja()//crear la baraja de cartas en base a las dos arrays 
        {
            foreach (int numero in numero)
            {
                foreach (string str in palo)
                {
                    baraja.Add($"{numero} de {str}");
                }
            }
        }
        public void barajarFALLIDO()//no baraja bien
        {
            List<string> barajaPerdida = new List<string>();
                for (int i = 0; i < baraja.Count; i++)
                {
                    int randm = rnd.Next(0, 39);
                    barajaPerdida.Add(baraja[randm]);
                }
                for(int h = 0; h < barajaPerdida.Count; h++)
                {
                    baraja.Remove(baraja[h]);
                    baraja.Add(barajaPerdida[h]);
                }
        }
        public void barajar()//mezclar cartas
        {
            List<string> barajaPerdida = new List<string>();
            int randm = rnd.Next(0, 39);
            baraja = baraja.OrderBy(baraja => rnd.Next()).ToList();
        }
        public void siguienteCarta()//devuelve la siguiente carta
        {
            if(cont < baraja.Count)
            {
                cont++;
                Console.WriteLine(baraja[cont-1]);
                
            }
            else
            {
                Console.WriteLine("baraja vacia!!!");
            }
        }
        public void cartasDisponibles()//muestra las cartas disponibles en el mazo 
        {
            if (cont < baraja.Count)
            {
                Console.WriteLine( (baraja.Count - cont).ToString() + " cartas disponibles");
            }
            else
            {
                Console.WriteLine("no hay cartas disponibles");
            }
        }
        public void darCartas(int num, List<string> user) //dado un número de cartas que nos pidan, le devolveremos ese número de cartas.
        {
            if (baraja.Count - cont >= num)
            {
                for (int i = 0; i < num; i++)
                {
                    user.Add(baraja[cont]);
                    //baraja.RemoveAt(i);
                    cont++;
                }
            }
            else
            {
                Console.WriteLine("no hay las cartas necesarias para dar");
            }
        }
        public void cartasMonto() //mostramos aquellas cartas que ya han salido, si no ha salido ninguna indicárselo al usuario
        {
            if (cont > 0)
            {
                for(int i = 0; i < cont; i++)
                {
                    Console.WriteLine(baraja[i]);
                }
                }
            else
            {
                Console.WriteLine("no ha salido ninguna carta");
            }
        }
        public void mostrarBaraja() //muestra todas las cartas hasta el final excluyendo las que si se sacaron
        {
            if (cont < baraja.Count)
            {
                for (int i = 0; i < baraja.Count-cont; i++)
                {
                    //Console.WriteLine("a");
                    Console.WriteLine(baraja[cont + i]);
                }
            }
            else
            {
                Console.WriteLine("baraja vacia!!!");
            }
        }
    }
}
