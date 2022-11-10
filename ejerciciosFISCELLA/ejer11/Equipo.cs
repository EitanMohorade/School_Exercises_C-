using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    internal class Equipo
    {
        string nombre = "";
        int dineroPorra = 0; //dinero que cada persona le dio al equipo 
        bool ganador = false;
        public bool Ganador { get { return ganador; } set { ganador = value; } }
        public int DineroPorra { get { return dineroPorra; } set { dineroPorra = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public Equipo(string nombre)
        {
            Nombre = nombre;
        }
        public Equipo(){}
    }
}
