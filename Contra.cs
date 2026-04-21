using System;

class Program
{
    static void Main()
    {
        string pass;

        Console.WriteLine("Ingrese contraseña:");
        pass = Console.ReadLine();

        if (pass == "Password123")
            Console.WriteLine("Bienvenido");
        else
            Console.WriteLine("Acceso denegado");
    }
}