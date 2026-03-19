internal class Program
{
    //verificar si un valor es positivo o negtivo
    private static void Main(string[] args)
    {
        //entradas
        Console.WriteLine("-----NUMEROS POSITIVOS Y NEGATIVOS------");
        //proceso
        int num;
        Console.WriteLine("Ingrese un numero: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0) 
        {
            Console.WriteLine("El numero es positivo");
        }
        else
        {
            Console.WriteLine("El numero es negativo");
        }
    }
}