using System;

class Program
{
    static void Main()
    {
        double angulo, rad;
        int opcion;

        Console.WriteLine("Ingrese ángulo en grados:");
        angulo = double.Parse(Console.ReadLine());

        rad = angulo * Math.PI / 180;

        Console.WriteLine("1. Seno");
        Console.WriteLine("2. Coseno");
        Console.WriteLine("3. Tangente");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Seno: " + Math.Sin(rad));
                break;
            case 2:
                Console.WriteLine("Coseno: " + Math.Cos(rad));
                break;
            case 3:
                Console.WriteLine("Tangente: " + Math.Tan(rad));
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}