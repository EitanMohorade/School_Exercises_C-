using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Juego
    {
        List<Jugador> jugadores = new List<Jugador>();
        Revolver revolver;
        public List<Jugador> Jugadores { get { return jugadores; } set { jugadores = value; } }
        public Revolver Revolver { get { return revolver; } set { revolver = value; } }
    }
}
