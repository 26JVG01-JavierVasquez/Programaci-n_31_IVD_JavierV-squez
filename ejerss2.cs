internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos valores numerico");
        double num1=Convert.ToDouble(Console.ReadLine());
        double num2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("**************");
        Console.WriteLine("Menu Principal");
        Console.WriteLine("**************");
        Console.WriteLine("1-Suma");
        Console.WriteLine("2-Resta");
        Console.WriteLine("3-Multi");
        Console.WriteLine("4-Divi");
        Console.WriteLine("5-Salir");
        Console.WriteLine("Digite el valor segun sea la operacion: [ ]");
        int opc=Convert.ToInt32(Console.ReadLine());

        string msj = "";
        double result=0;
        switch (opc)
        {
            case 1:
                msj = "\nSUMA\nla Suma es: ";
                result = num1 + num2;
                break;
            case 2:
                msj = "\nRESTA\nla Resta es: ";
                result = num1 - num2;
                break;
            case 3:
                msj = "\nMULTI\nla Multi es: ";
                result = num1 * num2;
                break;
            case 4:
                msj = "\nDIVI\nla Divi es: ";
                result = num1 / num2;
                break;
            case 5:
                msj = "SALIENDO DEL SISTEMA";
                break;
            default:
                msj = "Digite una opcion valida";
                break;
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine(msj);
        Console.WriteLine(result);
    }
}
