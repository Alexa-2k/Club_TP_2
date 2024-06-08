using Club_TP_2;
using System;

namespace Club_TP_2
{
    abstract class ServicioDeportivo : Servicio
    {
        private double duracion;
        private double valorHora;
              
       
        protected double Duracion { get => duracion; set => duracion = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
        

        public ServicioDeportivo(string nombre, double duracion, double valorHora)
        {
            this.Nombre = nombre;
            this.Duracion = duracion;
            this.ValorHora = valorHora;
            
        }

        public override void calcularPrecio()
        {
            Precio = Duracion * ValorHora * (1 + 0.5 * iva);
            
        }
    }
}