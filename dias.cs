using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número del 1 al 7 para representar el día de la semana (1 para lunes, 7 para domingo):");
        int dia = int.Parse(Console.ReadLine());

        if (dia == 6 || dia == 7)
            Console.WriteLine("Fin de semana");
        else
            Console.WriteLine("Entre semana");
    }
}