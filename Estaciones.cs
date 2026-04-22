using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una fecha (dia y mes) para determinar la estación del año:");
        int dia, mes;
        Console.WriteLine("Ingrese dia:");
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese mes:");
        mes = int.Parse(Console.ReadLine());

        if ((mes == 12 && dia >= 21) || mes == 1 || mes == 2 || (mes == 3 && dia <= 20))
            Console.WriteLine("Invierno");
        else if ((mes == 3 && dia >= 21) || mes == 4 || mes == 5 || (mes == 6 && dia <= 20))
            Console.WriteLine("Primavera");
        else if ((mes == 6 && dia >= 21) || mes == 7 || mes == 8 || (mes == 9 && dia <= 22))
            Console.WriteLine("Verano");
        else
            Console.WriteLine("Otoño");
    }
}