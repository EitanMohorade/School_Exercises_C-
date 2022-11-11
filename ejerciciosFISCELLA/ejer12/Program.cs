using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJETOS
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(new Jugador(1));
            jugadores.Add(new Jugador(2));
            jugadores.Add(new Jugador(3));
            jugadores.Add(new Jugador(4));
            jugadores.Add(new Jugador(5));
            jugadores.Add(new Jugador(6));
            Revolver revolver = new Revolver();
            Juego juego = new Juego(jugadores, revolver);
            //PROGRAMA
            juego.ronda();
            //
            Console.ReadKey();
        }
    }
}
