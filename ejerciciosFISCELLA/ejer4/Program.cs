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

            List<Electrodomestico> ListaElectrodomestico = new List<Electrodomestico>();
            for (var i= 0; i < 5; i++)
            {
                ListaElectrodomestico.Add(new Television(100, "ROJO", 'F', 13, 60, false));
                ListaElectrodomestico.Add(new Lavadora(100, "AZUL", 'A', 32, 50));
            }
            int contador = 0;
            foreach (Electrodomestico lista in ListaElectrodomestico)
            {

                if (lista is Television) { 
                    Console.WriteLine("El televisor cuesta " + lista.precioFinal());
                    contador++;
                }else if (lista is Lavadora)
                {
                    Console.WriteLine("La lavadora cuesta " + lista.precioFinal());
                    contador++;
                }
            }
            Console.WriteLine($"hay {contador} electrodomesticos");

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
        public Television(double precio, string color, char consumoEnergetico, double peso, double resolucion, bool sintonizadorTDT) : base(precio, color, consumoEnergetico, peso)
        {
            Resolucion = resolucion;
            SintonizadorTDT = sintonizadorTDT;
        }
        public override double precioFinal()
        {
            double precioFinal = 0;
            if (Resolucion > 40)
            {   
                precioFinal += ((Precio / 100) * 30);
            }
            if (SintonizadorTDT)
            {
                precioFinal += 50;
            }
            return precioFinal + Precio;
        }
    }
    public class Lavadora : Electrodomestico
    {
        double carga = 5;
        public double Carga { get { return carga; } set { carga = value; } } 
        public Lavadora() { }
        public Lavadora(double precio, double peso) : base(precio, peso){}
        public Lavadora(double precio, string color, char consumoEnergetico, double peso, double carga) : base(precio, color, consumoEnergetico, peso)
        {
            Carga = carga;
        }
        public override double precioFinal()
        {
            double precioFinal = 0;
            if(Carga > 30)
            {
                precioFinal += 50;
            }
            return precioFinal + Precio;
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
            Precio = precio;
            Peso = peso;
        }
        public Electrodomestico(double precio, string color, char consumoEnergetico, double peso) 
        {
            Precio = precio;
            Color = color;
            ConsumoEnergetico = consumoEnergetico;
            comprobarConsumoEnergetico(ConsumoEnergetico);
            comprobarColor(Color);
            Peso = peso;
        }

        public virtual double precioFinal()
        {
            double precioFinal = 0;
            double tamaño = 0;
            if (Peso > 0 && Peso <= 19) tamaño = 10;
            if (Peso >= 20 && Peso <= 49) tamaño = 50;
            if (Peso >= 50 && Peso <= 79) tamaño = 80;
            if (Peso > 80) tamaño = 100;

            precioFinal = (100 - ((int)ConsumoEnergetico - 65) * 20) + tamaño ;
            return precioFinal + Precio;
        }
        private void comprobarColor(string color)
        {
            if (color == Color)
            {
                Color = color;
            }
            else
            {
                Color = "blanco";
            }
        }
        private void comprobarConsumoEnergetico(char letra)
        {
            if (char.ToUpper(letra) == 'A' || char.ToUpper(letra) == 'B' || char.ToUpper(letra) == 'C' || char.ToUpper(letra) == 'D' || char.ToUpper(letra) == 'E')
            {
                ConsumoEnergetico = letra;
            }
            else
            {
                ConsumoEnergetico = 'F';
            }


               

        }
    }
}
