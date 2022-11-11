using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Revolver
    {
        //ATRIBUTOS
        static Random rnd = new Random();
        //int probabilidad = rnd.Next(0, 7);
        int posicionActual = 0;
        int posicionBala = 0;
        public int PosicionActual { get { return posicionActual; } set { posicionActual = value; } }
        public int PosicionBala { get { return posicionBala; } set { posicionBala = value; } }
        //CONSTRUCTORES
        public Revolver()
        {
            posicionActual = rnd.Next(1, 7);
            posicionBala = rnd.Next(1, 7);
        }
        //METODOS
        public bool disparar()//devuelve true si la bala coincide con la posición actual
        {
            if(posicionActual == posicionBala)
            {
                return true;
            }
            return false;
        }
        public void siguienteBala()//cambia a la siguiente posición del tambor
        {
            if(posicionActual == 6)
            {
                posicionActual = 1;
            }
            else
            {
                posicionActual++;
            }
        }
        public string toString()//muestra información del revolver (posición actual y donde está la bala)
        {
            return $"posicion de la bala {PosicionBala.ToString()} y del tambor {PosicionActual.ToString()}";
        }
    }
}
