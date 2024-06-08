using System;
using System.Collections.Generic;
using System.Text;

namespace Club_TP_2
{
    class Suplemento : Servicio
    {
        public Suplemento(string nombre, double ganancia, double precio)
        {
            this.Nombre = nombre;
            this.Ganancia = ganancia;
            this.Precio = precio;
        }
        public override void calcularPrecio()
        {          
            base.calcularPrecio();

            Console.WriteLine("Precio: $ {0:N2}", Precio); // informa el precio con 2 decimales


        }
    }

}//namespace end
