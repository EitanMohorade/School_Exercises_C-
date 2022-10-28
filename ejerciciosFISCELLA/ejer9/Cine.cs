using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    class Cine
    {
        int precio = 0;
        Pelicula peli = null;
        public int Precio { get { return precio; } set { precio = value; } }
        public Pelicula Peli { get { return peli; } set { peli = value; } }
        public Cine(int precio, Pelicula peli)
        {
            Precio = precio;
            Peli = peli;
        }
    }
}
