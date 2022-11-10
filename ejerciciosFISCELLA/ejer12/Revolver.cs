using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Revolver
    {
        int posicionActual = 0;
        int posicionBala = 0;
        public int PosicionActual { get { return posicionActual; } set { posicionActual = value; } }
        public int PosicionBala { get { return posicionBala; } set { posicionBala = value; } }
    }
}
