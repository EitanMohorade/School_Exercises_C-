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
        public string siguienteCarta()//devuelve la siguiente carta
        {
            if(cont < baraja.Count)
            {
                cont++;
                return baraja[cont-1];
            }
            else
            {
                return "baraja vacia!!!";
            }
        }
        public string cartasDisponibles()//muestra las cartas disponibles en el mazo 
        {
            if(siguienteCarta() == baraja[cont - 1])
            {
                return (baraja.Count - cont + 1).ToString() + " cartas disponibles";
            }
            else
            {
                return "no hay cartas disponibles";
            }
        }
    }
}
