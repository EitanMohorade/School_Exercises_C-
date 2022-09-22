using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1idem
{
    internal class Program
    {
        /* 
                     * Crea una clase llamada Cuenta que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).

                        El titular será obligatorio y la cantidad es opcional. Crea dos constructores que cumpla lo anterior.

                        Crea sus métodos get, set y toString.

                        Tendrá dos métodos especiales:

                    ingresar(double cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
                    retirar(double cantidad): se retira una cantidad a la cuenta, 
                    si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
        */
        public class Cuenta
        {
            string titular = "";
            double cantidad = 0;
            public string Titular { get { return titular; } set { titular = value; } }
            public double Cantidad { get { return cantidad; } set { cantidad = value; } }

            public Cuenta(string titular, int cantidad)
            {
                this.titular = titular;
                this.cantidad = cantidad;
            }
            public Cuenta(string titular)
            {
                this.titular= titular;
            }

            public bool ingresar(double cantidad)
            {

                if(cantidad < 0) { 
                    this.cantidad += cantidad;
                }
                return false;
            }
            public void retirar(double cantidad)
            {
                this.cantidad = cantidad - this.cantidad;
                if(this.cantidad < 0)
                {
                    this.cantidad = 0;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
