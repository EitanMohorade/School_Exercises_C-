using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            List<Espectador> espectados = new List<Espectador>();
            Espectador per1 = new Espectador("juan", 38, 130);
            Espectador per2 = new Espectador("ana", 24, 400);
            Espectador per3 = new Espectador("manuel", 18, 50);
            Espectador per4 = new Espectador("josefina", 45, 190);
            espectados.Add(per1);
            espectados.Add(per2);
            espectados.Add(per3);
            espectados.Add(per4);
            ///////////////////////
            Sala sala = new Sala(9, 5);
            Pelicula peli = new Pelicula(20);
            Cine cine = new Cine(200, peli);
            //////EJECUCION//////
            foreach(Espectador espectador in espectados)
            {
                if(espectador.Edad > cine.Peli.Edad)
                {
                    if(espectador.Dinero >= cine.Precio)
                    {
                        sala.ocuparRandom(espectador);
                        Console.WriteLine($"en el asiento {sala.AsientoOcupados[cont]}");
                        cont++;
                    }
                    else
                    {
                        Console.WriteLine($"{espectador.Nombre} no tiene el dinero suficiente para ver la pelicula");
                    }   
                }
                else
                {
                    Console.WriteLine($"{espectador.Nombre} no tiene la edad suficiente para ver la pelicula");
                }
            }
            ///////////////////
            sala.simulacion();
            //////////////////
            Console.ReadKey();
        }
    }
}
