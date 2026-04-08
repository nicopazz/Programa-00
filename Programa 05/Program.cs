namespace SistemaUTN;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 4: ESTADO ACADÉMICO ---");

        bool promocionaMateria = true;

        Console.WriteLine("6. TIPO LÓGICO (bool):");
        Console.WriteLine("   Solo puede ser 'true' o 'false'.");
        Console.WriteLine("   ¿Promociona Programacion 3?: " + promocionaMateria);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}