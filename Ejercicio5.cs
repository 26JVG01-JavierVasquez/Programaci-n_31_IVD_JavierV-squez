using System;

class Program
{
    static void Main()
    {
        int cantidad, opcion;
        double precio = 650, iva = 1.12;
        double total, descuento = 0;

        Console.WriteLine("Cantidad de impresoras:");
        cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("1. Efectivo");
        Console.WriteLine("2. Tarjeta");
        Console.WriteLine("3. Vale");
        opcion = int.Parse(Console.ReadLine());

        total = cantidad * precio * iva;

        switch (opcion)
        {
            case 1: descuento = 0.10; break;
            case 2: descuento = 0.05; break;
            case 3: descuento = 0.15; break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        double totalFinal = total - (total * descuento);

        Console.WriteLine("Total sin descuento: " + total);
        Console.WriteLine("Descuento: " + (descuento * 100) + "%");
        Console.WriteLine("Total a pagar: " + totalFinal);
    }
}