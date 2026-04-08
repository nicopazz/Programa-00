namespace EsmaeApp;

class Program
{
    static void Main(string[] args)
    {
        const string NOMBRE_TIENDA = "Esmae Tienda Online";
        const string VERSION_PLATAFORMA = "v2.0.5";
        const int MONTO_ENVIO_GRATIS = 50000;

        Console.WriteLine("=== " + NOMBRE_TIENDA + " (" + VERSION_PLATAFORMA + ") ===");
        Console.WriteLine("Cargando politicas de la tienda...");
        Console.WriteLine("Promocion: Envio gratis superando los $" + MONTO_ENVIO_GRATIS);
        
        const int TOTAL_CARRITO = 62500;
        const bool APLICA_ENVIO = TOTAL_CARRITO >= MONTO_ENVIO_GRATIS;

        Console.WriteLine("\nVerificando carrito de $" + TOTAL_CARRITO + "...");
        Console.WriteLine("Minimo requerido: $" + MONTO_ENVIO_GRATIS);
        Console.WriteLine("Envio bonificado (valor bool constante): " + APLICA_ENVIO);

        Console.WriteLine("Constante NOMBRE_TIENDA = " + NOMBRE_TIENDA);
        Console.WriteLine("Constante VERSION_PLATAFORMA = " + VERSION_PLATAFORMA);

        Console.ReadLine();
    }
}