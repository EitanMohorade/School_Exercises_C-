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
            for (int i = 0; i < 5; i++)
            {
                ListaSerie.Add(new Serie("ÑOQUI", 5, 'f', "AAAAAAA"));
                ListaVideojuegos.Add(new Videojuego("popo", 'a', "pedrito", 5));
            }
            ListaSerie.Add(new Serie("ÑOQsfafsaUI", 10, 'f', "AAAAAAA"));
            ListaSerie.Add(new Serie("ÑOQUI", 10, 'f', "AAAAAAA"));
            ListaVideojuegos.Add(new Videojuego("popo", 'a', "pedrito", 10));
            ListaVideojuegos.Add(new Videojuego("popo", 'a', "pedrito", 51));
            ListaVideojuegos.Add(new Videojuego("popo", 'a', "pedrito", 12));
            ListaSerie[1].entregar();
            ListaSerie[5].entregar();
            ListaVideojuegos[0].entregar();
            Console.WriteLine(ListaVideojuegos[5].compareTo(ListaVideojuegos[1]) +" "+ ListaSerie[2].Entregado);
            Videojuego contadorVid = ListaVideojuegos[0];
            Serie contadorSer = ListaSerie[0];
            foreach (Serie serie in ListaSerie) 
            { 
                if (serie.Entregado) Console.WriteLine("serie "+ serie.Titulo+" está entregado");
                if (serie.NumDeTemp > contadorSer.NumDeTemp) contadorSer = serie;
            }
            foreach (Videojuego videojuego in ListaVideojuegos) 
            { 
                if (videojuego.Entregado) Console.WriteLine("videojuego "+ videojuego.Titulo+" está entregado");
                if(videojuego.HsEstimada > contadorVid.HsEstimada) contadorVid = videojuego;
            }
            Console.WriteLine(contadorVid.HsEstimada+" "+ contadorSer.NumDeTemp);
            Console.ReadKey();
        }
    }
    public interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
        bool compareTo(Entregable objeto);
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
        public Videojuego() { }
        public Videojuego(string titulo, int hsEstimada)
        {
            Titulo = titulo;
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
        public bool compareTo(Entregable objeto)
        {
            if (objeto is Videojuego)
            {
                Videojuego videojuego = (Videojuego)objeto;
                if (videojuego.HsEstimada > HsEstimada) return true;
                else return false;
            }
            return false;
        }
    }
    class Serie : Entregable
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
        public bool compareTo(Entregable objeto)
        {
            if (objeto is Serie)
            {
                Serie serie = (Serie)objeto;
                if (serie.numDeTemp > NumDeTemp) return true;
                else return false;
            }
            return false;
        }
    }
}
