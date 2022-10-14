using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> lista = new List<Estudiante>();
            lista.Add(new Estudiante("jose", 21, 'M', 3));
             lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));

            Aula aula = new Aula(1, 12, "cancer");
            Profesores profesores = new Profesores("mariano", 30, 'M', "cancer");
            profesores.justificadas();
            
            Console.WriteLine(profesores.Faltas +"    "+ aula.disponibilidad(profesores, lista));

            foreach(Estudiante estudiante in lista) {
                estudiante.justificadas();
                Console.WriteLine(estudiante.Faltas + "   " + estudiante.justificadas()  +"  esta presente?:   "+ estudiante.Presente);

            }
            Console.WriteLine(aula.cursoPresente(lista));
            Console.ReadKey();
        }
    }
}
