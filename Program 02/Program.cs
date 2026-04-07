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
            Console.WriteLine("--- BLOQUE 1: INVENTARIO DE PRODUCTOS ---");

            int stockDisponible = 150;

            Console.WriteLine("1. TIPO ENTERO (int):");
            Console.WriteLine("   Para cantidades enteras, como el stock de un producto.");
            Console.WriteLine("   Valor guardado: " + stockDisponible);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
