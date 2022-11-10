using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    internal class porra
    {
        int cont = 0;
        List<persona> personaList;
        Partido partido;
        int dinero = 0; //dinero de TODA la porra
        public int Dinero { get { return dinero; } set { dinero = value; } }
        public Partido Partido { get { return partido; } set { partido = value; } }
        public List<persona> PersonaList { get { return personaList; } set { personaList = value; } }
        public porra(List<persona> personas, Partido partido)
        {
            Partido = partido;
            PersonaList = personas;
        }
        public void darEuro() //Cada jugador de la porra, pone un 1 euro cada jornada y decide el resultado de los partidos acordados
        {
            foreach(persona persona in PersonaList)
            {
                if(persona.Dinero > 1)
                {
                    persona.EquipoPer.DineroPorra++;
                    Dinero++;
                    persona.Dinero--;
                }
            }
        }
        public void conteoDeResultados() //deben acertar el resultado de dos partidos para llevarse el dinero del bote de la porra
        {
            foreach (persona persona in PersonaList)
            {
                if (partido.EquipoGanador == persona.EquipoPer)
                {
                    cont++;
                    Console.WriteLine($"la persona {persona.Nombre} gano la porra de {Dinero}");
                }else if (cont == 0)
                {
                    Console.WriteLine("nadie le atino al equipo ganador");
                }
            }
        }
    }
}
