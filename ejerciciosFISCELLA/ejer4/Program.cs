using System;
using System.Collections.Generic;
using System.Runtime;

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Crea un array de Electrodomesticos de 10 posiciones.
Asigna a cada posición un objeto de las clases anteriores con los valores que desees.
Ahora, recorre este array y ejecuta el método precioFinal().
Deberás mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, 
el de las lavadoras por otro y la suma de los Electrodomesticos 
(puedes crear objetos Electrodomestico, pero recuerda que Television y Lavadora también son electrodomésticos). 
Recuerda el uso operador instanceof.
Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, 
una lavadora de 200 y una televisión de 500, el resultado final sera de 1000 (300+200+500) 
para electrodomésticos, 200 para lavadora y 500 para televisión.
             */
            Console.ReadKey();
        }
    }
    public class Television : Electrodomestico
    {
        double resolucion = 20;
        bool sintonizadorTDT = false;
        public double Resolucion { get { return resolucion; } set { resolucion = value; } }
        public bool SintonizadorTDT { get { return sintonizadorTDT; } set { sintonizadorTDT = value; } }
        public Television() { }
        public Television(double precio, double peso) : base(precio, peso){}
        public Television(double resolucion, bool sintonizadorTDT) : base() { }
        public override void precioFinal()
        {
            if(this.resolucion > 40)
            {
                Precio += ((Precio / 100) * 30);
            }else if (sintonizadorTDT)
            {
                Precio += 50;
            }
        }
    }
    public class Lavadora : Electrodomestico
    {
        double carga = 0;
        public double Carga { get { return carga; } set { Carga = value; } } 
        public Lavadora() { }
        public Lavadora(double precio, double peso) : base(precio, peso){}
        public Lavadora(double carga) 
        {
            this.carga = carga;
        }
        public override void precioFinal()
        {
            if(this.carga > 30)
            {
                Precio += 50;
            }
        }
    }
    public class Electrodomestico
    {
        double precio = 100;
        string color = "blanco";
        char consumoEnergetico = 'F';
        double peso = 5;
        public double Precio { get { return precio; } set { precio = value; } }
        public string Color { get { return color; } set { color = value; } }
        public char ConsumoEnergetico { get { return consumoEnergetico; } set { consumoEnergetico = value; } }
        public double Peso { get { return peso; } set { peso = value; } }

        public Electrodomestico() { }
        public Electrodomestico(double precio, double peso) 
        {
            this.precio = precio;
            this.peso = peso;
        }
        public Electrodomestico(double precio, string color, char consumoEnergetico, double peso) 
        {
            this.precio = precio;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            comprobarConsumoEnergetico(this.consumoEnergetico);
            comprobarColor(this.color);
            this.peso = peso;
        }

        public virtual void precioFinal()
        {
            double tamaño = 0;
            if (this.peso > 0 && this.peso <= 19) tamaño = 10;
            if (this.peso >= 20 && this.peso <= 49) tamaño = 50;
            if (this.peso >= 50 && this.peso <= 79) tamaño = 80;
            if (this.peso > 80) tamaño = 100;

            this.precio = (100 - ((int)this.consumoEnergetico - 65) * 20) + tamaño ;
        }
        private void comprobarColor(string color)
        {
            if (color == this.color)
            {
                this.color = color;
            }
            else
            {
                this.color = "blanco";
            }
        }
        private void comprobarConsumoEnergetico(char letra)
        {
            if (char.ToUpper(letra) == 'A' || char.ToUpper(letra) == 'B' || char.ToUpper(letra) == 'C' || char.ToUpper(letra) == 'D' || char.ToUpper(letra) == 'E')
            {
                this.consumoEnergetico = letra;
            }
            else
            {
                this.consumoEnergetico = 'F';
            }


               

        }
    }
}
