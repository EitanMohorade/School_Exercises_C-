using System;

namespace ejercicioFISCELLA2
{
    class Program
    {
        class Persona
        {
            string nombre= "";
            Int16 edad=0;
            Int16 DNI;
            bool sexo=true;
            double peso=0;
            double altura=0;

            public Persona()
            {

            }
            public Persona(string nombre, Int16 edad, bool sexo)
            {
                this.altura = 0;
                this.DNI = 0;
                this.edad = edad;
                this.nombre = nombre;
                this.peso = 0;
                this.sexo = sexo;
            }
            public Persona(string nombre, Int16 edad, bool sexo, Int16 DNI, double peso, double altura)
            {
                this.altura = altura;
                this.DNI = DNI;
                this.edad = edad;
                this.nombre = nombre;
                this.peso = peso;
                this.sexo = sexo;
            }
            public double calcularMC(double peso)
            {
                this.peso = (peso / Math.Pow(this.altura , 2));
                if(this.peso < 20)
                {
                    return -1;
                }else if (this.peso >= 20 && this.peso <= 25)
                {
                    return 0;
                }else if (this.peso > 25)
                {
                    return 1;
                }
                return 10;
            }
            public bool esMayorDeEdad(Int16 edad)
            {

                if ()
                {

                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
