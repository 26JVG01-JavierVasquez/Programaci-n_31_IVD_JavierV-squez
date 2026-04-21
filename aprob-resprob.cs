using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la nota del estudiante: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 61)
            Console.WriteLine("Aprobado");
        else
            Console.WriteLine("Reprobado");
    }
}