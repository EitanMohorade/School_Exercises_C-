using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    internal class Partido
    {
        static Random Rndm = new Random();
        int idPartido = 0;
        List<Equipo> equipoGanador = new List<Equipo>();
        Equipo equipo1;
        Equipo equipo2;
        public Equipo Equipo1 { get { return equipo1; } set { equipo1 = value; } }
        public Equipo Equipo2 { get { return equipo2; } set { equipo2 = value; } }
        public List<Equipo> EquipoGanador { get { return equipoGanador; } set { equipoGanador = value; } }
        public int IdPartido { get { return idPartido; } set { idPartido = value; } }
        public Partido(Equipo equipo1, Equipo equipo2)
        {
            IdPartido++;
            Equipo1 = equipo1;
            Equipo2 = equipo2;
        }
        public void ganador()
        {
            Equipo empate = new Equipo("empate");
            int probabilida = Rndm.Next(0, 100);
            if (probabilida <= 45)
            {
                equipo1.Ganador = true;
                EquipoGanador.Add(Equipo1);
            }
            else if (probabilida <= 85)
            {
                equipo2.Ganador = true;
                EquipoGanador.Add(Equipo2);
            }
            else
            {
                EquipoGanador.Add(empate);
            }
        }
    }
}
