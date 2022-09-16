using System;
using System.Collections.Generic;
using System.Runtime;

namespace ejer3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Password password = new Password();
            //Console.WriteLine($"La contraseña es: {password.Contraseña}");


            int contador = 0;
            Console.WriteLine("ingrese cuantas passwords quiere ingresar: ");
            short cantContra = Convert.ToInt16(Console.ReadLine());

            Password[] arrayContra = new Password[cantContra];
            Boolean[] arrayFuerte = new Boolean[cantContra];
            for(int i = 0; i < arrayContra.Length; i++)
            {
                
                Console.WriteLine($"cuantos caracteres queres que tenga la contraseña {i}: ");
                int cantCaracter = Convert.ToInt32(Console.ReadLine());

                arrayContra[i] = new Password(cantCaracter);
            }

            foreach (Password pass in arrayContra)
            {
                Console.WriteLine($"la longitud de la contraseña {contador} es de {pass.Longitud}");
                if (arrayFuerte[contador] = pass.esFuerte())
                {
                    Console.WriteLine("es fuerte");
                }
                else
                {
                    Console.WriteLine("NO es fuerte");
                }
                contador++;
            }


            
            Console.ReadKey();
        }
    }

    class Password
    {
        int longitud;
        string contraseña;
        public int Longitud { get { return longitud; } set { longitud = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }

        public Password()
        {
            this.longitud = 8;
        }
        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = generarPassword(); //rd.Next(this.longitud);
        }

        public bool esFuerte()
        {
            string contra = this.contraseña;
            int cargaUpper = 0;
            int cargaLower = 0;
            int cargaNumber = 0;

            for (int i = 0; i < contra.Length; i++) { 
            if (Char.IsUpper(contra, i))
                {
                        cargaUpper++;
                }
            if(Char.IsLower(contra, i))
                {
                    cargaLower++;
                }
            if(Char.IsNumber(contra, i))
                {
                    cargaNumber++;
                }
            }
            if(cargaUpper > 2 && cargaLower > 1 && cargaNumber >5)
            {
                return true;
            }
            return false;
        }
        public string generarPassword()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789421240%$#@";
            int longitud = caracteres.Length;
            char letra;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < this.longitud; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
            return contraseniaAleatoria;
        }
    }
}
