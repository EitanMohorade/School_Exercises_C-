using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    class Pelicula
    {
        //título, duración, edad mínima y director.
        string titulo = "";
        int duracion = 0;
        int edad = 0;
        string director = "";
        public string Titulo {get{return titulo;} set { titulo = value; } }
        public int Duracion { get { return duracion; } set { duracion = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public string Director { get { return director; } set { director = value; } }
        public Pelicula(int edad)
        {
            Edad = edad;
        }
    }
}
