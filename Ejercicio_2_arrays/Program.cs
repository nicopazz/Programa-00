using System;

namespace Arrays2
{

  class Program
  {
    static void Main(string[] args)
    {

      // INICIALIZACIÓN DIRECTA Y FOREACH

      Console.WriteLine(" INICIALIZACIÓN Y FOREACH ");

      // Ejercicio 2.1
      string[] serviciosCriv = { "Branding", "Social Media", "Desarrollo Web", "Asesorías" };
      Console.WriteLine("Servicios de la agencia:");
      foreach (string servicio in serviciosCriv)
      {
        Console.WriteLine("- " + servicio);
      }

      // Ejercicio 2.2
      string[] razas = { "Bulldog", "Caniche", "Labrador", "Mestizo" };
      Console.WriteLine("\nRazas atendidas hoy:");
      foreach (string raza in razas)
      {
        Console.WriteLine("- " + raza);
      }

      // Ejercicio 2.3
      string[] categoriasEsmae = { "Iluminación", "Textiles", "Muebles", "Cerámica" };
      Console.WriteLine("\nCategorías disponibles:");
      foreach (string categoria in categoriasEsmae)
      {
        Console.WriteLine("- " + categoria);
      }

      // Ejercicio 2.4
      string[] stackDev = { "MongoDB", "Express", "React", "Node.js", "Next.js" };
      Console.WriteLine("\nTecnologías del proyecto:");
      foreach (string tech in stackDev)
      {
        Console.WriteLine("- " + tech);
      }

      // Ejercicio 2.5
      string[] herramientas = { "Lija", "Pincel", "Rodillo", "Esmalte Sintético" };
      Console.WriteLine("\nHerramientas preparadas:");
      foreach (string herramienta in herramientas)
      {
        Console.WriteLine("- " + herramienta);
      }


      Console.WriteLine("\nPresione Enter para pasar finalizar el programa...");
      Console.ReadLine();
      Console.Clear();
    }
  }
}