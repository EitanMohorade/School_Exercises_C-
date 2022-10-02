using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro(2132, "cool", "yo", 321);
            Libro libro2 = new Libro(8829, "LOCO", "vos", 493);
            Console.WriteLine( libro1.InfoLibro());
            if(libro1.NumeroDePagina > libro2.NumeroDePagina)
            {
                Console.WriteLine($"el libro {libro1.Titulo} tiene mas paginas que el libro {libro2.Titulo}");
            }else
            { 
                Console.WriteLine($"el libro {libro2.Titulo} tiene mas paginas que el libro {libro1.Titulo}");
            }
            Console.ReadKey();
        }
    }
    class Libro
    {
        int isbn = 0;
        string titulo = "";
        string autor = "";
        int numeroDePagina = 0;
        public int ISBN { get { return isbn; } set { isbn = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
        public int NumeroDePagina { get { return numeroDePagina; } set { numeroDePagina = value; } }

        public Libro(int isbn, string titulo, string autor, int numeroDePagina)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            NumeroDePagina = numeroDePagina;
        }
        public Libro() { }
        public string InfoLibro()
        {
            return $"El libro con {this.ISBN} ISBN creado por el autor {this.Autor} tiene {this.NumeroDePagina} páginas";
        }
    }
}
