using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    class Espectador
    {
        string nombre = "";
        int edad = 0;
        int dinero = 0;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public int Dinero { get { return dinero; } set { dinero = value; } }
        public Espectador (string nombre, int edad, int dinero)
        {
            Edad = edad;
            Dinero = dinero;
            Nombre = nombre;
        }
    }
}
