using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8
{
    class Profesores : Aula
    {
        string nombre = "";
        int edad = 0;
        char sexo = 'M';
        string materias = "";
        public string Nombre { get { return nombre; } set { value = nombre; } }
        public int Edad { get { return edad; } set { value = edad; } }
        public char Sexo { get { return sexo; } set { value = sexo; } }
        public string Materias { get { return materias; } set { value = materias; } }

        public Profesores(string nombre, int edad, char sexo, string materias)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            if (materias == "matematicas" || materias == "fisica" || materias == "filosofia")
            { 
                Materias = materias;
            }
        }
        public override void justificadas()
        {
            Random rdm = new Random();
            int probabilidad = rdm.Next(1, 100);
            if (probabilidad <= 20)
            {
                faltar();
            }
        }
    }
}
