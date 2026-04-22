internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rango de estudiante");
        Console.WriteLine("Digite una letra (A, B, C, D y F)");
        char letra = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            case 'A': 
                Console.WriteLine("EXELENTE");
                break;
            case 'B':
                Console.WriteLine("BUENO");
                break;
            case 'C':
                Console.WriteLine("REGULAR");
                break;
            case 'D':
                Console.WriteLine("DEFICIENTE");
                break;
            case 'F':
                Console.WriteLine("REPROBADO");
                break;
            default:
                Console.WriteLine("Escriba una letra valida");
                break;
        }
    }
}
