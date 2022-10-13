using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    class Estudiantes : Persona
    {
        static Random rdm = new Random();
        int calificacion = 0;
        public int Calificacion { get { return calificacion; } set { value = calificacion; } }
        public Estudiantes(string nombre, int edad, char sexo, int calificacion) : base(nombre, edad, sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Calificacion = calificacion;
        }
        public override void justificadas()
        {
            int probabilidad = rdm.Next(1, 100);
            if (probabilidad <= 50)
            {
                faltar();
            }
        }
    }
}
