using System;
using System.Collections.Generic;

namespace ejerciciosFISCELLA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

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
            this.contraseña = rd.Next(0, this.longitud);
        }
    }
}