using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    internal class Raices
    {
        double a = 0;
        double b = 0;
        double c = 0;
        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        double C { get { return c; } set { c = value; } }

        public Raices(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void obtenerRaices()
        {

            double raizePositiva = ((B * -1) + Math.Sqrt(((Math.Pow(B, 2)) - (4 * A * C)))) / (2 * A);
            double raizeNegativa = ((B * -1) - Math.Sqrt(((Math.Pow(B, 2)) - (4 * A * C)))) / (2 * A);
            Console.WriteLine($"{raizePositiva} y {raizeNegativa}");
           
        }
        public void obtenerRaiz()
        {
            double raizPositiva = ((B * -1) + Math.Sqrt(((Math.Pow(B, 2)) - (4 * A * C)))) / (2 * A);
            double raizNegativa = ((B * -1) - Math.Sqrt(((Math.Pow(B, 2)) - (4 * A * C)))) / (2 * A);
            if (((Math.Pow(B, 2)) - (4 * A * C))==0)
            {
                Console.WriteLine(raizPositiva);
            }
            else Console.WriteLine("hay mas de una raiz");
        }
        public double getDiscriminante()
        {
            double discriminante = (Math.Pow(B, 2)) - 4 * A * C;
            return discriminante;
        }
        public bool tieneRaices()
        {
            double discriminante = (Math.Pow(B, 2)) - 4 * A * C;
            if (discriminante >= 0)
            {
                return true;
            }else return false;
        }
        public bool tieneRaiz()
        {
            double discriminante = (Math.Pow(B, 2)) - 4 * A * C;
            if(discriminante == 0) { return true; }
            else return false;
        }
        public void calcular() //no la terminé
        {
            obtenerRaices();
        }
    }
}
