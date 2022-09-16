using System;
using System.Collections.Generic;


namespace ejerciciosFISCELLA3
{
    class Password
    {
        int longitud;
        int contraseña;
        public int Longitud { get { return longitud; } set { longitud = value; } }
        public int Contraseña { get { return contraseña; } set { contraseña = value; } }

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

        public void esFuerte()
        {

        }
        public void generarPassword()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 10;
            this.longitud = longitudContrasenia;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}