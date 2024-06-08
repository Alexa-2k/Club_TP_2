using System;
using System.Collections.Generic;
using System.Text;

namespace Club_TP_2
{
    class Test

    {
        static Facturacion facturacion = new Facturacion();
        static List<Servicio> servicios = new List<Servicio>();

        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nMENU \n ");
                Console.WriteLine("1. Agregar un nuevo servicio\n");
                Console.WriteLine("2. Mostrar detalles de los servicios\n");
                Console.WriteLine("3. Salir del programa\n");
                Console.Write("Seleccione una opción: \n");
                int opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        AgregarNuevoServicio();
                        break;
                    case 2:
                        MostrarDetallesServicios();
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
                        
            Console.WriteLine("\nMonto Total Facturado: $ {0:N2}", facturacion.MontoTotalFacturado()); // informa el precio con 2 decimales


            Console.WriteLine($"\nCantidad de Servicios Simples (Clases grupales con menos de 10 alumnos): {facturacion.CantServiciosSimples()}");
        }

        static void AgregarNuevoServicio()
        {
            Console.Clear();

            Console.Write($"\n\nIngrese el tipo de servicio \n(S: Suplemento, E: Entrenamiento Personalizado, G: Clase Grupal): ");
            string tipo = Console.ReadLine();

            switch (tipo.ToUpper())
            {
                case "S":
                    AgregarSuplemento();
                    break;
                case "E":
                    AgregarEntrenamientoPersonalizado();
                    break;
                case "G":
                    AgregarClaseGrupal();
                    break;
                default:
                    Console.WriteLine("Tipo de servicio no reconocido.");
                    return;
            }
        }
        static void AgregarSuplemento()
        {
            Console.Write("\nIngrese el nombre del suplemento: ");
            string nombre = Console.ReadLine();
            nombre = nombre.ToUpper();

            Console.Write("Ingrese el porcentaje de ganancia: ");
            double ganancia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el precio de lista: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Suplemento suplemento = new Suplemento(nombre, ganancia, precio);
            suplemento.calcularPrecio();
            servicios.Add(suplemento);
            facturacion.HistorialFacturacion.Add(suplemento);
        }

        static void AgregarEntrenamientoPersonalizado()
        {
            Console.Write("\nIngrese el nombre del entrenamiento: ");
            string nombre = Console.ReadLine();
            nombre = nombre.ToUpper();

            Console.Write("Ingrese la duración en horas: ");
            double duracion = Convert.ToDouble(Console.ReadLine());

            double valorHora = 2000;

            EntrenamientoPersonalizado entrenamiento = new EntrenamientoPersonalizado(nombre, duracion, valorHora);
            entrenamiento.calcularPrecio();
            servicios.Add(entrenamiento);
            facturacion.HistorialFacturacion.Add(entrenamiento);
        }

        static void AgregarClaseGrupal()
        {
            Console.Write("\nIngrese el nombre de la clase: ");
            string nombre = Console.ReadLine();
            nombre = nombre.ToUpper();

            Console.Write("Ingrese la duración en minutos: ");
            double duracionMinutos = Convert.ToDouble(Console.ReadLine());
            double duracion = duracionMinutos / 60;

            Console.Write("Ingrese el número de participantes: ");
            int numParticipantes = Convert.ToInt32(Console.ReadLine());
            int valorHora = 60 * 80;

                  
            ClaseGrupal grupal = new ClaseGrupal(nombre, duracion, valorHora, numParticipantes); // 
            grupal.calcularPrecio();
            servicios.Add(grupal);
            facturacion.HistorialFacturacion.Add(grupal);

        }

        static void MostrarDetallesServicios()
        {
            Console.Clear();

            if (servicios.Count != 0)
            {
                Console.WriteLine("DETALLE DE SERVICIOS \n");
                foreach (var servicio in servicios)
                {
                    Console.Write($"{servicio.Nombre}");
                    Console.WriteLine("  Precio: $ {0:N2}", servicio.Precio);
                }
            }
            else
            {
                Console.WriteLine("No hay servicios listados \n\n");
            }

        }
    }
}