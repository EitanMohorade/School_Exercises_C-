using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    class Profesores : Persona
    {
        static Random rdm = new Random();
        int probabilidad = rdm.Next(1, 100);
        List<string> materias = new List<string>();
        public List<string> Materias { get { return materias; } set { materias = value; } }
        public Profesores(string nombre, int edad, char sexo, List<string> materias) : base(nombre, edad, sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Materias = materias;
        }
        public override bool justificadas()
        {
            if (probabilidad <= 20)
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
