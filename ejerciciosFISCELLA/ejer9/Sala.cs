using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    internal class Sala
    {
        int columna = 0;
        int fila = 0;
        char[] letra = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K'};
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public List<string> Asiento = new List<string>();
        public List<string> AsientoOcupados = new List<string>();
        static Random rnd = new Random();
        public int Columna { get { return columna; } set { columna = value; } }
        public int Fila { get { return fila; } set { fila = value; } }
        public Sala (int columna, int fila)
        {
            Columna = columna;
            Fila = fila;
            int cont = 0;
            for (int a = 0; a < fila; a++)
            {
                cont++;
                for (int b = 0; b < columna; b++)
                {
                    Asiento.Add($"{array[fila - cont]}{letra[b]}");
                }
            }
        }
        public void simulacion()
        {
            int cont = 0;
            for (int a = 0; a < fila; a++)
            {
                //cont++;
                for (int b = 0; b < columna; b++)
                {
                    Console.Write(Asiento[cont]+"   ");
                    cont++;
                }
                //cont++;
                Console.WriteLine("\n");
            }
        }
        public void ocuparRandom(Espectador espectador)
        {
            int probabilidad = rnd.Next(columna * fila);
            if (Asiento[probabilidad] != "ocupado")
            { 
                AsientoOcupados.Add($"{Asiento[probabilidad]} ocupado por: {espectador.Nombre}");
                //Asiento[probabilidad] = $"{Asiento[probabilidad - 1]}{espectador.Nombre}";
                Asiento.Insert(probabilidad, $"ocupado");
                Asiento.RemoveAt(probabilidad + 1);
            }else
            {
                int cont = 0;
                foreach(string item in Asiento)
                {
                    if (Asiento[cont] != "ocupado")
                    {
                        AsientoOcupados.Add($"{Asiento[cont]} ocupado por: {espectador.Nombre}");
                        Asiento.Insert(cont, $"ocupado");
                        Asiento.RemoveAt(cont + 1);
                        break;
                    }
                        cont++;
                }
            }
        }
    }
}
