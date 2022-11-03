using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    internal class Baraja
    {
        static Random rnd = new Random();
        string[] palo = { "espada", "basto", "oro", "copa" };
        int[] numero = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        public List<string> baraja = new List<string>();
        ///CONSTRUCTORES///
        public Baraja()
        {
            foreach(int numero in numero)
            {
                foreach(string str in palo)
                {
                    baraja.Add($"{numero} de {str}");
                }
            }
        }
        ///METODOS///
        public void barajar()
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
    }
}
