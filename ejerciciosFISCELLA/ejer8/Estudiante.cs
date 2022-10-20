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
        public int Calificacion { get { return calificacion; } set { calificacion = value; } }
        public Estudiante(string nombre, int edad, char sexo, int calificacion) : base(nombre, edad, sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            if (calificacion > 10)
            {
                Calificacion = 10;
            }
            else
            {
                Calificacion = calificacion;
            }
        }
        public override bool justificadas()
        {
            //int probabilidad = rdm.Next(1, 100);
            if (probabilidad <= 50)
            {
                sumaFalta();
                Presente = false;
                return true;
            }
            else return false;
        }
        public override void faltar()
        {
                Presente = false;
                sumaFalta();
        }
    }
}
