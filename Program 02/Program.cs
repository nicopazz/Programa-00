using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo 1
            Console.WriteLine("--- BLOQUE 1: INVENTARIO DE PRODUCTOS ---");

            int stockDisponible = 150;

            Console.WriteLine("1. TIPO ENTERO (int):");
            Console.WriteLine("   Para cantidades enteras, como el stock de un producto.");
            Console.WriteLine("   Valor guardado: " + stockDisponible);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // Ejemplo 2
            Console.WriteLine("--- BLOQUE 2: PRECIO DE VENTA ---");

            double precioProducto = 25999.99;

            Console.WriteLine("2. TIPO DECIMAL (double):");
            Console.WriteLine("   Para números con coma, como el precio de un producto en la tienda.");
            Console.WriteLine("   Valor guardado: $" + precioProducto);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // Ejemplo 3
            Console.WriteLine("--- BLOQUE 3: NOMBRE DEL USUARIO ---");

            string nombreUsuario = "Administrador";

            Console.WriteLine("3. TIPO CADENA DE TEXTO (string):");
            Console.WriteLine("   Para palabras o frases, como el nombre de quien inicia sesión.");
            Console.WriteLine("   Valor guardado: " + nombreUsuario);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // Ejemplo 4
            Console.WriteLine("--- BLOQUE 4: DISPONIBILIDAD ---");

            bool envioGratis = true;

            Console.WriteLine("4. TIPO BOOLEANO (bool):");
            Console.WriteLine("   Para valores de verdadero o falso, como saber si un producto tiene envío gratis.");
            Console.WriteLine("   Valor guardado: " + envioGratis);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // Ejemplo 5
            Console.WriteLine("--- BLOQUE 5: SECTOR DEL ALMACÉN ---");

            char pasillo = 'C';

            Console.WriteLine("5. TIPO CARÁCTER (char):");
            Console.WriteLine("   Para almacenar una única letra o símbolo, como el pasillo donde se ubica un producto.");
            Console.WriteLine("   Valor guardado: " + pasillo);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

        }
    }
}
