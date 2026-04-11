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
            //Ejemplo 1
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

            // Ejemplo 2
            Console.WriteLine("--- BLOQUE 2: CONTROL DE FLOTA ---");

            double kilometraje = 154.5;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Para registrar distancias recorridas por los vehículos.");
            Console.WriteLine("   Valor guardado: " + kilometraje + " km");

            decimal costoPeaje = 1250.50m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   Para registrar gastos exactos en dinero durante el viaje.");
            Console.WriteLine("   Valor guardado: $" + costoPeaje);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // Ejemplo 3
            Console.WriteLine("--- BLOQUE 2: RECURSOS HUMANOS ---");

            double horasTrabajadas = 160.5;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Para contabilizar el tiempo de trabajo con fracciones.");
            Console.WriteLine("   Valor guardado: " + horasTrabajadas + " horas");

            decimal salarioMensual = 850300.75m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   Para liquidaciones de sueldos y valores monetarios precisos.");
            Console.WriteLine("   Valor guardado: $" + salarioMensual);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // Ejemplo 4
            Console.WriteLine("--- BLOQUE 2: COTIZACIÓN DE VIAJES ---");

            double pesoEquipaje = 23.4;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Para pesar las valijas en el mostrador del aeropuerto.");
            Console.WriteLine("   Valor guardado: " + pesoEquipaje + " kg");

            decimal tarifaVuelo = 450800.00m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   Para calcular el costo final de los pasajes de avión.");
            Console.WriteLine("   Valor guardado: $" + tarifaVuelo);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            // Ejemplo 5
            Console.WriteLine("--- BLOQUE 2: PRESUPUESTO DE OBRA ---");

            double metrosCuadrados = 85.75;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Para medir la superficie de un terreno o habitación.");
            Console.WriteLine("   Valor guardado: " + metrosCuadrados + " m2");

            decimal costoMateriales = 3250400.20m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   Para calcular presupuestos y compras de materiales.");
            Console.WriteLine("   Valor guardado: $" + costoMateriales);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
