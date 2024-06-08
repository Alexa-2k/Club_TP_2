using System;
using System.Collections.Generic;
using System.Text;

namespace Club_TP_2
{
    class EntrenamientoPersonalizado : ServicioDeportivo
    {
        public EntrenamientoPersonalizado(string nombre, double duracion, double valorHora) : base(nombre, duracion, valorHora)
        { }

        public override void calcularPrecio()
        {
            base.calcularPrecio(); // Llama al método de la clase padre para calcular el precio base
           Console.WriteLine("Precio: $ {0:N2}", Precio) ;  //informa el precio con 2 decimales

        }

    }
}//namespace end
