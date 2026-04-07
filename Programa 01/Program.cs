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
        }
    }
}
