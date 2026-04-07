using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 2: GESTIÓN DE PRODUCTOS ---");

            double pesoEnvio = 2.5;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Para medidas físicas de los paquetes.");
            Console.WriteLine("   Valor guardado: " + pesoEnvio + " kg");

            decimal precioFinal = 125500.99m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   Para el precio de los artículos en la tienda.");
            Console.WriteLine("   Valor guardado: $" + precioFinal);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
