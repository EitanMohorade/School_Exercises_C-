using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letra = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int cont = 0;
            int columna = 9;
            int fila = 5;
            for (int a = 0; a < fila; a++)
            {
                cont++;
                for (int b = 0; b < columna; b++)
                {
                    Console.Write(array[fila-cont] +" "+ letra[b] + "     ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
