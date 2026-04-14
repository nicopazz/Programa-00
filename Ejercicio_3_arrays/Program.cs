using System;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
           
         // USO DE .LENGTH Y BUCLE FOR
          
            Console.WriteLine(" .LENGTH Y FOR ");

            // Ejercicio 3.1
            int[] tasasRefresco = { 60, 120, 144, 240 };
            Console.WriteLine("Evaluando " + tasasRefresco.Length + " configuraciones de monitor.");
            for (int i = 0; i < tasasRefresco.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": " + tasasRefresco[i] + "Hz");
            }

            // Ejercicio 3.2
            double[] pesos = { 4.5, 12.0, 25.5, 8.2 };
            Console.WriteLine("\nRegistros de peso (" + pesos.Length + " en total):");
            for (int i = 0; i < pesos.Length; i++)
            {
                Console.WriteLine("Mascota " + (i + 1) + " pesa: " + pesos[i] + " kg");
            }

            // Ejercicio 3.3
            int[] ventasDiarias = { 3, 5, 2, 8, 4 };
            Console.WriteLine("\nReporte de los últimos " + ventasDiarias.Length + " días:");
            for (int i = 0; i < ventasDiarias.Length; i++)
            {
                Console.WriteLine("Día " + (i + 1) + ": " + ventasDiarias[i] + " ventas");
            }

            // Ejercicio 3.4
            double[] probabilidades = { 0.15, 0.35, 0.25, 0.25 };
            Console.WriteLine("\nAnálisis de " + probabilidades.Length + " eventos posibles:");
            for (int i = 0; i < probabilidades.Length; i++)
            {
                Console.WriteLine("Evento " + i + " tiene una probabilidad de: " + probabilidades[i]);
            }

            // Ejercicio 3.5
            int[] reviews = { 5, 4, 5, 3, 5, 4 };
            Console.WriteLine("\nMostrando " + reviews.Length + " reseñas recientes:");
            for (int i = 0; i < reviews.Length; i++)
            {
                Console.WriteLine("Reseña " + i + ": " + reviews[i] + " estrellas");
            }


            Console.WriteLine("\nPresione Enter para finalizar el programa...");
            Console.ReadLine(); 
        }
    }
}