using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el departamento al que desea enviar su mensaje:");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Ventas - Juan Perez - ventas@empresa.com");
                break;
            case 2:
                Console.WriteLine("Recepcion - Maria Lopez - recepcion@empresa.com");
                break;
            case 3:
                Console.WriteLine("Direccion - Carlos Ruiz - direccion@empresa.com");
                break;
            case 4:
                Console.WriteLine("Compras - Ana Gomez - compras@empresa.com");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}