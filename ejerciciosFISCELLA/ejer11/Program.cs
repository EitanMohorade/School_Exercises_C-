using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creacion de objetos
            Equipo equipo1 = new Equipo("boca");
            Equipo equipo2 = new Equipo("saca chispas");
            List<persona> personas = new List<persona>();
            personas.Add(new persona("manuel", 20, equipo1));
            personas.Add(new persona("samuel", 20, equipo1));
            personas.Add(new persona("manuela", 20, equipo1));
            personas.Add(new persona("juan", 20, equipo1));
            personas.Add(new persona("roberto", 20, equipo2));
            Partido partido = new Partido(equipo1, equipo2);
            porra porra = new porra(personas, partido);
            //




            Console.ReadKey();
        }
    }
}
