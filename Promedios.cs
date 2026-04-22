internal class Program
{
    private static void Main(string[] args)
    {
        double n1, n2, n3, n4, n5, prom;

        Console.WriteLine("Ingrese 5 notas:");
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        n4 = double.Parse(Console.ReadLine());
        n5 = double.Parse(Console.ReadLine());

        prom = (n1 + n2 + n3 + n4 + n5) / 5;

        if (prom >= 61)
            Console.WriteLine("Aprueba con promedio: " + prom);
        else
            Console.WriteLine("Reprueba con promedio: " + prom);
    }
}