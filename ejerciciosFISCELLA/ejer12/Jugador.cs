using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Jugador
    {
        int id = 0;
        string nombre = "";
        bool vivo = true;
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public bool Vivo { get { return vivo; } set { vivo = value; } }
    }
}
