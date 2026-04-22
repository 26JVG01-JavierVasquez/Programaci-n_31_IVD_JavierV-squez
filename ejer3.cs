using System;

class Program
{
    static void Main()
    {
        int sector, cantidad;
        double precio = 0, total;

        Console.WriteLine("1. Palco (300)");
        Console.WriteLine("2. Tribuna (110)");
        Console.WriteLine("3. Preferencia (60)");
        Console.WriteLine("4. Generales (40)");
        sector = int.Parse(Console.ReadLine());

        Console.WriteLine("Cantidad:");
        cantidad = int.Parse(Console.ReadLine());

        switch (sector)
        {
            case 1: precio = 300; break;
            case 2: precio = 110; break;
            case 3: precio = 60; break;
            case 4: precio = 40; break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        total = precio * cantidad;
        Console.WriteLine("Total: Q" + total);
    }
}