using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    internal class Porra
    {
        int cont = 0;
        List<Persona> personaList;
        Partido partido;
        int dinero = 0; //dinero de TODA la porra
        public int Dinero { get { return dinero; } set { dinero = value; } }
        public Partido Partido { get { return partido; } set { partido = value; } }
        public List<Persona> PersonaList { get { return personaList; } set { personaList = value; } }
        public Porra(List<Persona> personas, Partido partido)
        {
            Partido = partido;
            PersonaList = personas;
        }
        public void darEuro() //Cada jugador de la porra, pone un 1 euro cada jornada y decide el resultado de los partidos acordados
        {
            foreach(Persona persona in PersonaList)
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
            foreach (Persona persona in PersonaList)
            {
                if (partido.EquipoGanador.Contains(persona.EquipoPer))
                {
                    cont++;
                }
            }
            if(cont > 0)
            {
                //dinero = dinero / cont;
            }
        }
        public string darBote() //la primera persona que eligio al equipo ganador, gana el bote
        {
            foreach (Persona persona in PersonaList)
            {
                if (partido.EquipoGanador[0] == persona.EquipoPer && partido.EquipoGanador[1] == persona.EquipoPer)
                {
                    return persona.Nombre + " ganó la porra de " + dinero.ToString();
                }
            }
            return "hubo empate";
        }
    }
}
