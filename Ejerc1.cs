internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******************");
        Console.WriteLine("*Dia De La Semana*");
        Console.WriteLine("******************");
        Console.Write("Digite Un Numero del 1 al 7: ");
        int dia=Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("LUNES");
                break;
            case 2:
                Console.WriteLine("MARTES");
                break;
            case 3:
                Console.WriteLine("MIERCOLES");
                break;
            case 4:
                Console.WriteLine("JUEVES");
                break;
            case 5:
                Console.WriteLine("VIERNES");
                break;
            case 6:
                Console.WriteLine("SABADO");
                break;
            case 7:
                Console.WriteLine("DOMINGO");
                break;
            default:
                Console.WriteLine("Digite un valor del 1 al 7");
                break;
        }
    }
}
