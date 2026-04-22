using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los tres ángulos del triángulo:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a == 60 && b == 60 && c == 60)
            Console.WriteLine("Equilatero");
        else if (a == b || a == c || b == c)
            Console.WriteLine("Isosceles");
        else
            Console.WriteLine("Escaleno");
    }
}