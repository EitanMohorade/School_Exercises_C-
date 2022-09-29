using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Serie> ListaSerie = new List<Serie>();
            List<Videojuego> ListaVideojuegos = new List<Videojuego>();
            for (int i= 0; i < 5; i++)
            {
                ListaSerie.Add(new Serie());
                ListaVideojuegos.Add(new Videojuego());
            }
            Console.ReadKey();
        }
    }
    public interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        Entregable compareTo(Entregable objeto);
    }
    class Videojuego : Entregable
    {
        string titulo = "";
        bool entregado = false;
        char genero;
        string compania = "";
        int hsEstimada = 10;
        public string Compania { get { return compania; } set { compania = value; } }
        public int HsEstimada { get{ return hsEstimada; } set { hsEstimada = value; } }
        public char Genero { get { return genero; } set { genero = value; } }
        public bool Entregado;
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public Videojuego(string titulo, char genero, string compania, int hsEstimada)
        {
            Titulo = titulo;
            Genero = genero;
            Compania = compania;
            HsEstimada = hsEstimada;
        }
        public void entregar()
        {
            Entregado = true;
        }
        public void devolver()
        {
            Entregado = false;
        }
        public bool isEntregado()
        {
            return Entregado;
        }
        public Entregable compareTo(Entregable objeto)
        {
            if (hsEstimada == objeto.HsEstimada)
            {

            }else
            {

            }
        }
    }
    class Serie
    {
        string titulo = "";
        int numDeTemp = 3;
        bool entregado = false;
        char genero;
        string creador = "";
        public string Creador { get { return creador; } set { creador = value; } }
        public char Genero { get { return genero; } set { genero = value; } }
        public bool Entregado;
        public int NumDeTemp { get { return numDeTemp; } set { numDeTemp = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public Serie() { }
        public Serie(string titulo, int numDeTemp, char genero, string creador)
        {
            Titulo = titulo;
            NumDeTemp = numDeTemp;
            Genero = genero;
            Creador = creador;
        }
        public Serie(string titulo, string creador)
        {
            Titulo = titulo;
            Creador = creador;
        }
    
    }
}
