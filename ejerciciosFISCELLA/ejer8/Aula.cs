using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    class Aula
    {
        int id = 0;
        int maxAlumnos = 0;
        List<string> materias = new List<string>();
        public List<string> Materias { get { return materias; } set { materias = value; } }
        public int Id { get { return id; } set { id = value; } }
        public int MaxAlumnos { get { return maxAlumnos; } set { maxAlumnos = value; } }
        public Aula(int id, int maxAlumnos, List<string> materia)
        {
            Id = id;
            MaxAlumnos = maxAlumnos;
            Materias = materia;
        }
        public bool disponibilidad(Profesores profe, List<Estudiante> estudiantes)
        { 
            if (profe.Presente == true)
            {
                if(profe.Materias == Materias) {
                    if (estudiantes.Count < maxAlumnos) { 
                        if (cursoPresente(estudiantes) == true)
                        {
                            return true;
                        }
                        else return false;
                    }
                    return false;
                }
                return false;
            }
            else return false;
        }
        public bool cursoPresente(List<Estudiante> lista)
        {
            int contador = 0;
            int mitadCurso = lista.Count / 2;
            foreach (Estudiante estudiante in lista)
            {
                if (estudiante.Presente == false)
                {
                    contador++;
                }
            }
            if (contador >= mitadCurso)
            {
                return false;
            }
            else return true; //anda
        }
    }
}