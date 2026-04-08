namespace TiendaInsumosPC;

class Program
{
    static void Main(string[] args)
    {
        const decimal DESCUENTO_EFECTIVO = 0.10m;
        const bool ENTREGA_INMEDIATA = true;
        const char MONEDA = '$';

        Console.WriteLine("--- SISTEMA DE VENTAS HARDWARE ---");
        Console.WriteLine("Apto para entrega inmediata: " + ENTREGA_INMEDIATA);

        decimal precioMonitorAsus = 285500.50m;
        decimal montoDescuento = precioMonitorAsus * DESCUENTO_EFECTIVO;
        decimal totalAPagar = precioMonitorAsus - montoDescuento;

        Console.WriteLine("\nDetalle de la cotizacion:");
        Console.WriteLine("Precio de lista: " + MONEDA + precioMonitorAsus);
        Console.WriteLine("Descuento en efectivo (" + (DESCUENTO_EFECTIVO * 100) + "%): -" + MONEDA + montoDescuento);
        Console.WriteLine("TOTAL CON DESCUENTO: " + MONEDA + totalAPagar);

        Console.ReadLine();
    }
}