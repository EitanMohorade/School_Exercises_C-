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
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("manuel", 20, equipo1));
            personas.Add(new Persona("samuel", 20, equipo1));
            personas.Add(new Persona("manuela", 20, equipo1));
            personas.Add(new Persona("juan", 20, equipo2));
            personas.Add(new Persona("roberto", 20, equipo2));
            Partido partido = new Partido(equipo1, equipo2);
            Porra porra = new Porra(personas, partido);
            //
            int cont = 0;
            int jornadas = 2;

            //
            //primer partido
            Console.WriteLine("     PRIMER PARTIDO");
            for (int i=0; i < jornadas; i++)
            {
                porra.darEuro();
            }
            partido.ganador();
            Console.WriteLine($" *dinero de la porra: { porra.Dinero} \n  *equipo ganador: {partido.EquipoGanador[0].Nombre}");
            foreach(Persona persona in personas)
            {
                Console.WriteLine($"la persona {persona.Nombre} votó para el equipo {persona.EquipoPer.Nombre}");
            }
            //
            //segundo partido
            Console.WriteLine("\n     SEGUNDO PARTIDO");
            for (int i = 0; i < jornadas; i++)
            {
                porra.darEuro();
            }
            partido.ganador();
            Console.WriteLine($" *dinero de la porra: { porra.Dinero} \n  *equipo ganador: {partido.EquipoGanador[1].Nombre}");
            foreach (Persona persona in personas)
            {
                Console.WriteLine($"la persona {persona.Nombre} votó para el equipo {persona.EquipoPer.Nombre}");
            }
            porra.conteoDeResultados();
            Console.WriteLine($"\n *{porra.darBote()}");
            //
            Console.WriteLine("\n   DINERO DE CADA PERSONA");
            foreach (Persona persona in personas)
            {
                Console.WriteLine($"la persona {persona.Nombre} tiene ${persona.Dinero} ");
            }


            Console.ReadKey();
        }
    }
}
