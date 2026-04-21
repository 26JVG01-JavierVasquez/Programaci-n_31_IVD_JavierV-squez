internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        Console.WriteLine("1 Ventas, 2 Soporte, 3 Finanzas, 4 RRHH");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: Console.WriteLine("Ventas"); break;
            case 2: Console.WriteLine("Soporte"); break;
            case 3: Console.WriteLine("Finanzas"); break;
            case 4: Console.WriteLine("RRHH"); break;
            default: Console.WriteLine("Opcion invalida"); break;
        }
    }
}