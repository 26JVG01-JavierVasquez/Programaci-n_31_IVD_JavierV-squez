using System;

class Program
{
    static void Main()
    {
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 100)
            Console.WriteLine("Exelente");
        else if (nota >= 90)
            Console.WriteLine("Muy Bien");
        else if (nota >= 80)
            Console.WriteLine("Bien");
        else if (nota >= 70)
            Console.WriteLine("Regular");
        else if (nota >= 60) 
            Console.WriteLine("Deficiente");
        else
            Console.WriteLine("Nota no válida");
    }
}