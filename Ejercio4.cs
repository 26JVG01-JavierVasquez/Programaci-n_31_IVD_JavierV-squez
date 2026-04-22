using System;

class Program
{
    static void Main()
    {
        int opcion;

        Console.WriteLine("1 → Hamburguesa");
        Console.WriteLine("2 → Pizza");
        Console.WriteLine("3 → Pollo frito");
        Console.WriteLine("4 → Ensalada");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Pediste Hamburguesa");
                break;
            case 2:
                Console.WriteLine("Pediste Pizza");
                break;
            case 3:
                Console.WriteLine("Pediste Pollo frito");
                break;
            case 4:
                Console.WriteLine("Pediste Ensalada");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}
