internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rango de estudiante");
        Console.WriteLine("Ingrese una letra A,B,C,D,F");
        char letra = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            case 'A':
                Console.WriteLine("Excelente");
                break;
            case 'B':
                Console.WriteLine("bueno");
                break;
            case 'C':
                Console.WriteLine("regular");
                break;
            case 'D':
                Console.WriteLine("Deficiente");
                break;
            case 'F':
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Letra no válida");
                break;
        }
        }
}