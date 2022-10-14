using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    class Estudiante : Persona
    {
        static Random rdm = new Random();
        int probabilidad = rdm.Next(1, 100);
        int calificacion = 0;
        public int Calificacion { get { return calificacion; } set { value = calificacion; } }
        public Estudiante(string nombre, int edad, char sexo, int calificacion) : base(nombre, edad, sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Calificacion = calificacion;
        }
        public override bool justificadas()
        {
            //int probabilidad = rdm.Next(1, 100);
            if (probabilidad <= 80)
            {
                sumaFalta();
                return true;
            }
            else return false;
        }
        public override void faltar()
        {
            if (justificadas())
            {
                Presente = false;
            }else Presente = true;
        }
    }
}
