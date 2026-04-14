using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // FUNDAMENTOS DE ARREGLOS 
            
            Console.WriteLine(" Ejercicios 1.1 a 1.5 ");

            // Ejercicio 1.1
            int[] edadesMascotas = new int[3];
            edadesMascotas[0] = 2;
            edadesMascotas[1] = 5;
            edadesMascotas[2] = 10;
            Console.WriteLine("Edad mascota 1: " + edadesMascotas[0]);

            // Ejercicio 1.2
            double[] preciosDeco = new double[2];
            preciosDeco[0] = 15500.50;
            preciosDeco[1] = 8900.00;
            Console.WriteLine("Precio artículo 2: $" + preciosDeco[1]);

            // Ejercicio 1.3
            int[] notasExamen = new int[4];
            notasExamen[0] = 8;
            notasExamen[1] = 7;
            notasExamen[2] = 9;
            notasExamen[3] = 10;
            Console.WriteLine("Última nota: " + notasExamen[3]);

            // Ejercicio 1.4
            int[] temperaturasGPU = new int[3];
            temperaturasGPU[0] = 65;
            temperaturasGPU[1] = 72;
            temperaturasGPU[2] = 78;
            Console.WriteLine("Temperatura máxima registrada: " + temperaturasGPU[2] + "°C");

            // Ejercicio 1.5
            int[] horasAgencia = new int[2];
            horasAgencia[0] = 15;
            horasAgencia[1] = 22;
            Console.WriteLine("Horas proyecto web: " + horasAgencia[0]);

            Console.WriteLine("\nPresione Enter para pasar finalizar el programa...");
            Console.ReadLine();
            Console.Clear();

            
        }
    }
}