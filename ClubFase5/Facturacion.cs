using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Numerics;

namespace Club_TP_2
{


   public class Facturacion
    {
       

        private List<Servicio> historialFacturacion = new List<Servicio>();

        internal List<Servicio> HistorialFacturacion { get => historialFacturacion; set => historialFacturacion = value; }

        public void AgregarServicio(Servicio servicio)
        {
            HistorialFacturacion.Add(servicio);
           
        }
        
        public double MontoTotalFacturado()
        {
            double total = 0;
            foreach (var servicio in HistorialFacturacion)
            {
                total += servicio.Precio;
            }
            return total;
        }

        public int CantServiciosSimples()
        {
            int count = 0;
            foreach (var servicio in HistorialFacturacion)
            {
            if (servicio is ClaseGrupal grupo && grupo.NumParticipantes < 10)

          //if (servicio is ClaseGrupal grupo && ((ClaseGrupal)servicio).NumParticipantes <= 10)
                {
                    count++;
                }
            }
            return count;
        }
    }

}//namespace end