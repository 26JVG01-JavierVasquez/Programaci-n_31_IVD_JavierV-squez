internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escribir dos variables numericos");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("-------MENÜ PRINSIPAL--------");
        Console.WriteLine("1- Suma");
        Console.WriteLine("2- Resta");
        Console.WriteLine("3- Multiplicacion");
        Console.WriteLine("4- Division");
        Console.WriteLine("5- Salir");
        Console.WriteLine("Digite la opcion que desea realizar: ()");
        int opcion = Convert.ToInt32(Console.ReadLine());
        string msg = "";
        double Result = 0;
        switch (opcion)
        {
            case 1:
                msg = "\n suma \n es:";
                Result =num1 + num2;
                break;
            case 2:
                msg = "\n resta \n es:";
                Result = num1 - num2;
                break;
            case 3:
                msg = "\n multiplicacion \n es:";
                Result = num1 * num2;
                break;
            case 4:
                msg = "\n division \n es:";
                Result = num1 / num2;
                break;
            case 5:
                msg = "Saliendo del programa...";
                break;
            default:
                msg = "Digite un numero correcto";
                break;

        }
        Console.clear();
        Console.WriteLine(msg);
        Console.WriteLine(Result);

    }
}