using System;
using System.Collections.Generic;
using System.Text;

namespace Club_TP_2
{
    class ClaseGrupal : ServicioDeportivo
    {
        private int numParticipantes;
       

        public int NumParticipantes { get => numParticipantes; set => numParticipantes = value; }

        public ClaseGrupal(string nombre, double duracion, double valorHora, int numParticipantes) : base(nombre, duracion, valorHora) 
        {
            this.NumParticipantes = numParticipantes;
        }

        public override void calcularPrecio()
        {
            base.calcularPrecio();// Llama al método de la clase padre para calcular el precio base

            if (NumParticipantes > 10)
            {
                Precio *= 0.8;
                // Descuento si hay más de 10 participantes
            }

             Console.WriteLine("Precio: $ {0:N2}", Precio); // informa el precio con 2 decimales

        }

    }

}//namespace end
