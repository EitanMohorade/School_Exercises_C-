using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Juego
    {
        //ATRIBUTOS
        int cont = 0;
        List<Jugador> jugadores = new List<Jugador>();
        Revolver revolver;
        public List<Jugador> Jugadores { get { return jugadores; } set { jugadores = value; } }
        public Revolver Revolver { get { return revolver; } set { revolver = value; } }
        //CONSTRUCTOR
        public Juego(List<Jugador> jugadors, Revolver revolver)
        {
            Jugadores = jugadors;
            Revolver = revolver;
        }
        //METODOS
        public bool finJuego()//Cuando un jugador muere, devuelve true
        {
            foreach(Jugador jugador in jugadores) 
            {
                if (jugador.Vivo) { } else
                {
                    return true;
                }
            }
            return false;
        }
        public void ronda()//cada jugador se apunta y se dispara, se informara del estado de la partida (El jugador se dispara, no ha muerto en esa ronda, etc.)
        {
            Console.WriteLine($"RONDA {++cont}");
            foreach(Jugador jugador in jugadores)
            {
                jugador.disparar(Revolver);
                Console.WriteLine($"El {jugador.Nombre} se dispararó. Esta vivo? {jugador.Vivo}");
                if (jugador.Vivo == false)
                {
                    Console.WriteLine("JUEGO TERMINADO");
                    break;
                }
                else
                {
                    Revolver.siguienteBala();
                }
            }
        }
    }
}
