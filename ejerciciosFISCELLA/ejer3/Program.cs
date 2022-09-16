using System;
using System.Collections.Generic;
using System.Runtime;

namespace ejer3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Password password = new Password(9);


            Console.WriteLine(password.Contraseña);

            if (password.esFuerte())
            {
                Console.WriteLine("es segura");
            }
            else
            {
                Console.WriteLine("NO es segura");
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
            Random rd = new Random();


            this.longitud = longitud;
            this.contraseña = generarPassword(); //rd.Next(this.longitud);
        }

        public bool esFuerte()
        {
            string contra = this.contraseña;
            if (Char.IsUpper(contra, 2)) {
                return true;
            }
            return false;
        }
        public string generarPassword()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
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
