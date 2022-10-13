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
            Estudiantes estudiante = new Estudiantes("jose", 21, 'M', 3);
            estudiante.justificadas();
            estudiante.justificadas();
            estudiante.justificadas();
            estudiante.justificadas();
            Console.WriteLine(estudiante.Faltas);
            Console.ReadKey();
        }
    }
}
