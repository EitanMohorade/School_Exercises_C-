using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    internal class Persona
    {
        string nombre = "";
        int dinero = 0; //dinero de la persona
        Equipo equipo;
        public Equipo EquipoPer { get { return equipo; } set { equipo = value; } }
        public int Dinero { get { return dinero; } set { dinero = value; } }
        public string Nombre { get { return nombre; }  set { nombre = value; } }  
        public Persona(string nombre, int dinero, Equipo equipo)
        {
            EquipoPer = equipo;
            Dinero = dinero;
            Nombre = nombre;
        }
    }
}
