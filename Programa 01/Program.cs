using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1
            Console.WriteLine("--- ROLLINGVET: INGRESO DE PACIENTE ---");

            Console.Write("Ingresa el nombre de la mascota: ");
            string nombreMascota = Console.ReadLine();

            Console.Write("Ingresa la edad de la mascota en años: ");
            string edadTexto = Console.ReadLine();
            int edad = int.Parse(edadTexto);

            Console.Write("Ingresa el peso en kg (ejemplo: 5,2): ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- FICHA CREADA ---");
            Console.WriteLine("Paciente: " + nombreMascota);
            Console.WriteLine("Año de nacimiento aproximado: " + (2026 - edad));
            Console.WriteLine("Peso registrado: " + peso + " kg");

            Console.WriteLine("\nPresiona ENTER para volver al menú principal.");
            Console.ReadLine();

            // Ejemplo 2
            Console.WriteLine("--- ROLLINGVET: REGISTRO DE VACUNA ---");

            Console.Write("Ingresa el nombre de la mascota: ");
            string mascotaVacuna = Console.ReadLine();

            Console.Write("Ingresa el número de dosis (1, 2 o 3): ");
            string dosisTexto = Console.ReadLine();
            int dosis = int.Parse(dosisTexto);

            Console.Write("Ingresa el costo de la vacuna: ");
            double costoVacuna = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- VACUNA REGISTRADA ---");
            Console.WriteLine("Paciente: " + mascotaVacuna);
            Console.WriteLine("Dosis aplicada: Número " + dosis);
            Console.WriteLine("Total a cobrar: $" + costoVacuna);

            Console.WriteLine("\nPresiona ENTER para volver al menú principal.");
            Console.ReadLine();

            // Ejemplo 3
            Console.WriteLine("--- ROLLINGVET: CONTROL DE RUTINA ---");

            Console.Write("Ingresa el nombre del paciente: ");
            string nombrePaciente = Console.ReadLine();

            Console.Write("Ingresa el ritmo cardíaco (latidos por minuto): ");
            string latidosTexto = Console.ReadLine();
            int latidos = int.Parse(latidosTexto);

            Console.Write("Ingresa la temperatura corporal (ejemplo: 38,5): ");
            double temperatura = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- RESULTADOS DEL CONTROL ---");
            Console.WriteLine("Paciente: " + nombrePaciente);
            Console.WriteLine("Frecuencia cardíaca: " + latidos + " ppm");
            Console.WriteLine("Temperatura: " + temperatura + " °C");

            Console.WriteLine("\nPresiona ENTER para volver al menú principal.");
            Console.ReadLine();

            // Ejemplo 4
            Console.WriteLine("--- ROLLINGVET: TURNO DE PELUQUERÍA ---");

            Console.Write("Ingresa el nombre de la mascota: ");
            string perroPeluqueria = Console.ReadLine();

            Console.Write("Ingresa el nivel de corte (1 al 5): ");
            string nivelTexto = Console.ReadLine();
            int nivelCorte = int.Parse(nivelTexto);

            Console.Write("Ingresa el tiempo estimado en horas (ejemplo: 1,5): ");
            double horasEstimadas = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- TURNO ASIGNADO ---");
            Console.WriteLine("Mascota: " + perroPeluqueria);
            Console.WriteLine("Estilo de corte: Nivel " + nivelCorte);
            Console.WriteLine("Tiempo de espera: " + (horasEstimadas * 60) + " minutos");

            Console.WriteLine("\nPresiona ENTER para volver al menú principal.");
            Console.ReadLine();

            // Ejemplo 5
            Console.WriteLine("--- ROLLINGVET: VENTA DE MOSTRADOR ---");

            Console.Write("Ingresa el nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Ingresa la cantidad a llevar: ");
            string cantidadTexto = Console.ReadLine();
            int cantidad = int.Parse(cantidadTexto);

            Console.Write("Ingresa el precio unitario: ");
            double precioUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- TICKET DE VENTA ---");
            Console.WriteLine("Producto: " + nombreProducto);
            Console.WriteLine("Unidades: " + cantidad);
            Console.WriteLine("Total a pagar: $" + (cantidad * precioUnitario));

            Console.WriteLine("\nPresiona ENTER para volver al menú principal.");
            Console.ReadLine();
        }

    }
}
