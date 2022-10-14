using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    class Profesores : Persona
    {
        string materias = "";
        public string Materias { get { return materias; } set { value = materias; } }

        public Profesores(string nombre, int edad, char sexo, string materias) : base(nombre, edad, sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            if (materias == "matematicas" || materias == "fisica" || materias == "filosofia")
            { 
                Materias = materias;
            }
        }
        public override bool justificadas()
        {
            Random rdm = new Random();
            int probabilidad = rdm.Next(1, 100);
            if (probabilidad <= 20)
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
            }
            else Presente = true;
        }
    }
}
