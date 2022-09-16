using System;

namespace ejerciciosFISCELLA
{
    class Program
    {

      
        static void Main(string[] args)
        {
            Cuenta cuentarda = new Cuenta("hola", 10);
            if (cuentarda.ingresar(-10))
            {
                Console.WriteLine("se ingreso plata");
            }
            else { 
            Console.WriteLine("no se ingreso nada");
            }
            Console.ReadKey();
        }
    }
    class Cuenta
    {
        string titular = "";
        double cantidad = 0;
        public string Titular { get { return titular; } set { titular = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }
        public Cuenta(string titular)
        {
            this.titular = titular;
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public bool ingresar(double plata)
        {
            if (plata >= 0)
            {
                this.cantidad += plata;
                return true;
            }
            return false;
        }
        public bool retirar(double plata)
        {
            this.cantidad = this.cantidad - plata;
            if (this.cantidad < 0)
            {
                this.cantidad = 0;
                return true;
            }
            return false;
        }
    }
}
