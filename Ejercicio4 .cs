using System;

class Program
{
    static void Main()
    {
        double valor;
        int opcion;

        Console.WriteLine("Ingrese valor en metros:");
        valor = double.Parse(Console.ReadLine());

        Console.WriteLine("1. A pies");
        Console.WriteLine("2. A centímetros");
        Console.WriteLine("3. A pulgadas");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Resultado: " + (valor * 3.28));
                break;
            case 2:
                Console.WriteLine("Resultado: " + (valor * 100));
                break;
            case 3:
                Console.WriteLine("Resultado: " + (valor * 39.37));
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}