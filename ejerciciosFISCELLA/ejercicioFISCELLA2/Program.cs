using System;
using System.Collections.Generic;
using System.Runtime;

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


            for (int i = 0; i < ListaPersona.Count; i++)
            {


                if (ListaPersona[i].calcularMC() == 1)
                {
                    Console.WriteLine($"persona n*{i} valor mayor que 25");
                }
                else if (ListaPersona[i].calcularMC() == -1)
                {
                    Console.WriteLine($"persona n*{i} valor menor que 20");
                }
                else if (ListaPersona[i].calcularMC() == 0)
                {
                    Console.WriteLine($"persona n*{i} peso ideal");
                }

                if (ListaPersona[i].esMayorDeEdad())
                {
                    Console.WriteLine($"persona n*{i} es mayor de edad");
                }
                else
                {
                    Console.WriteLine($"persona n*{i} es menor de edad");
                }

                //if (per.Nombre != null || per.Altura == 0) { //SI ES QUE QUERES QUE SOLO APAREZCA EL Q TIENE TODOS LOS DATOS
                    Console.WriteLine($"el nombre de la persona n*{i} es {ListaPersona[i].Nombre}. Tiene {ListaPersona[i].Edad} con una altura de {ListaPersona[i].Altura} M y peso de {ListaPersona[i].Peso} kg");
                //}
            }

            
            Console.ReadKey();
        }

        class Persona
        {
            string nombre = "";
            Int16 edad = 0;
            Int32 dni;
            string sexo = "H";
            double peso = 0;
            double altura = 0;

            public string Nombre { get { return nombre; } set { nombre = value; } } 
            public Int16 Edad { get { return edad; } set { edad = value; } }
            public Int32 DNI { get { return dni; }  }
            public string Sexo { get { return sexo; } set { sexo = value; } }
            public double Peso { get { return peso; } set { peso = value; } }
            public double Altura { 
                get { 
                    return altura; 
                } 
                set { 
                    altura = value; 
                } 
            }

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

                if (this.edad >= 18)
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
