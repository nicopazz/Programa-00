using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            string nombreAgencia = "Agencia CRIV";
            Console.WriteLine("4. TIPO TEXTO (string):");
            Console.WriteLine("   Valor guardado: " + nombreAgencia);

            char planMarketing = 'P';
            Console.WriteLine("\n5. TIPO CARÁCTER (char):");
            Console.WriteLine("   Valor guardado: '" + planMarketing + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}
