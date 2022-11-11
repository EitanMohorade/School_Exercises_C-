using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Jugador
    {
        //ATRIBUTOS
        int id = 0;
        string nombre = "jugador";
        bool vivo = true;
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public bool Vivo { get { return vivo; } set { vivo = value; } }
        //CONSTRUCTORES
        public Jugador(int id)
        {
            Id = id;
            nombre = nombre + id.ToString();
        }
        //METODOS
        public void disparar(Revolver r)//el jugador se apunta y se dispara, si la bala se dispara, el jugador muere. 
        {
            if (r.disparar())
            {
                Vivo = false;
            }
            else
            {
                Vivo = true;
            }
        }
    }
}
