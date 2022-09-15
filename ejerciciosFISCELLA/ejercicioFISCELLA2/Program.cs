using System;
using System.Collections.Generic;

namespace ejercicioFISCELLA2
{
    class Program
    {

        static void Main(string[] args)
        {
            Persona random = new Persona();
            //Persona persona = new Persona("jose", 18, "F", random.generarDni(), 20, 100);

            List<Persona> ListaPersona = new List<Persona>();

            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine("ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("ingrese el edad: ");
                short edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("ingrese el sexo: ");
                string sexo = Console.ReadLine();
                Console.WriteLine("ingrese el peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese el altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                ListaPersona.Add(new Persona(nombre, edad, sexo,  peso, altura));
                ListaPersona.Add(new Persona(nombre, edad, sexo));
                ListaPersona.Add(new Persona());
            }


            foreach(Persona per in ListaPersona)
            {
                if (per.calcularMC() == 1)
                {
                    Console.WriteLine("valor mayor que 25");
                }
                else if (per.calcularMC() == -1)
                {
                    Console.WriteLine("valor menor que 20");
                }
                else if (per.calcularMC() == 0)
                {
                    Console.WriteLine("peso ideal");
                }

                if (per.esMayorDeEdad())
                {
                    Console.WriteLine("es mayor de edad");
                }
                else
                {
                    Console.WriteLine("es menor de edad");
                }

                Console.WriteLine(per.nombre);
            }
            
            Console.ReadKey();
        }

        class Persona
        {
            public string nombre { get { return nombre; } set {  } } 
            public Int16 edad { get { return edad; } set {  } }
            public Int32 DNI { get { return DNI; }  }
            public string sexo { get { return sexo; } set { sexo = "H"; } }
            public double peso { get { return peso; } set {  } }
            public double altura { get { return altura; } set { } }

            public Persona()
            {

            }
            public Persona(string nombre, Int16 edad, string sexo)
            {
                this.altura = 0;
                this.edad = edad;
                this.nombre = nombre;
                this.peso = 0;
                this.sexo = sexo;
            }
            public Persona(string nombre, Int16 edad, string sexo, double peso, double altura)
            {
                this.altura = altura;
                this.edad = edad;
                this.nombre = nombre;
                this.peso = peso;
                this.sexo = sexo;
            }
            public double calcularMC()
            {
                this.peso = (this.peso / Math.Pow(this.altura, 2));
                if (this.peso < 20)
                {
                    return -1;
                }
                else if (this.peso >= 20 && this.peso <= 25)
                {
                    return 0;
                }
                else if (this.peso > 25)
                {
                    return 1;
                }
                return 10;
            }
            public bool esMayorDeEdad()
            {

                if (this.edad > 18)
                {
                    return true;
                }
                return false;
            }

            public void comprobarSexo(string sexo)
            {

                if (sexo == "M" && this.sexo == "M")
                {

                }
                else if (sexo == "H" && this.sexo == "H")
                {

                }
                else
                {
                    this.sexo = "H";
                }

            }
            public void generarDni()
            {
                Random rd = new Random();

                int dni = rd.Next(0, 99999999);

            }
        }
    }
}
