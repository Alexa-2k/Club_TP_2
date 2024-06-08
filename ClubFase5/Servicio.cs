using System;
using System.Collections.Generic;
using System.Text;

namespace Club_TP_2
{
    public abstract class Servicio
    {
        private string nombre;
        private double precio;
        private double ganancia;
        public const double iva = 0.21;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Ganancia { get => ganancia; set => ganancia = value; }
        public double Iva { get => iva; }

        public virtual void calcularPrecio()
        {
            Precio = Precio * (1 + Ganancia / 100) * ( 1 + Iva);
        }
        
    }
}
