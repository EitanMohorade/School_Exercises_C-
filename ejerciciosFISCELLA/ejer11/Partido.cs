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
        int probabilida = Rndm.Next(1, 2);
        int idPartido = 0;
        Equipo equipoGanador;
        Equipo equipo1;
        Equipo equipo2;
        public Equipo Equipo1 { get { return equipo1; } set { equipo1 = value; } }
        public Equipo Equipo2 { get { return equipo2; } set { equipo2 = value; } }
        public Equipo EquipoGanador { get { return equipoGanador; } set { equipoGanador = value; } }
        public int IdPartido { get { return idPartido; } set { idPartido = value; } }
        public Partido(Equipo equipo1, Equipo equipo2)
        {
            IdPartido++;
            Equipo1 = equipo1;
            Equipo2 = equipo2;
        }
        public void ganador()
        {
            if(probabilida == 1)
            {
                equipoGanador = equipo1;
                equipo1.Ganador = true;
            }
            else
            {
                equipoGanador = equipo2;
                equipo2.Ganador = true;
            }
        }
    }
}
