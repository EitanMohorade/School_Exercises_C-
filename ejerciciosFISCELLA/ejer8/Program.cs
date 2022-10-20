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
            lista.Add(new Estudiante("jose", 21, 'M', 30));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'F', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 30));
            lista.Add(new Estudiante("jose", 21, 'F', 3));
            lista.Add(new Estudiante("jose", 21, 'F', 3));
            lista.Add(new Estudiante("jose", 21, 'F', 30));
            lista.Add(new Estudiante("jose", 21, 'M', 3));      
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            lista.Add(new Estudiante("jose", 21, 'M', 3));
            List<string> materia = new List<string>();
            materia.Add("matematicas");
            materia.Add("fisica");
            Aula aula = new Aula(1, 12, materia);
            Profesores profesores = new Profesores("mariano", 30, 'M', materia);
            profesores.justificadas();
            int cont = 0;
            int contM = 0;
            int contF = 0;
            foreach (Estudiante estudiante in lista) {
                estudiante.justificadas();
                Console.WriteLine($"el alumno {estudiante.Nombre} tiene { estudiante.Faltas} faltas. esta presente? {estudiante.Presente}     {estudiante.Calificacion}");
                if (estudiante.Presente == true)
                {
                    cont++;
                }
            }
            Console.WriteLine($"el profe está presente? {profesores.Presente}, curso presente?  {aula.cursoPresente(lista)},  materia del profe: {profesores.Materias[0]}, materia del aula: {aula.Materias[0]}");
            Console.WriteLine($"aula disponible:  {aula.disponibilidad(profesores, lista)}, cant presentes: {cont}");
            if(aula.disponibilidad(profesores, lista))
            {
                foreach(Estudiante estudiante in lista) { 
                    if(estudiante.Calificacion > 5) 
                    { 
                        if(estudiante.Sexo == 'M')
                        {
                            contM++;
                        }else if (estudiante.Sexo == 'F')
                        {
                            contF++;
                        }
                    }
                }
                Console.WriteLine($"Hay {contF} chicas y {contM} chicos aprobados");
            }
            Console.ReadKey();
        }
    }
}
