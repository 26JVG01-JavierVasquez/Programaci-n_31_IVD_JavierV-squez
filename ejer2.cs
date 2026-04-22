using System;

class Program
{
    static void Main()
    {
        char c;

        Console.WriteLine("Ingrese un carácter:");
        c = Convert.ToChar(Console.ReadLine());

        if (c >= '0' && c <= '9')
        {
            Console.WriteLine("Es dígito");
        }
        else
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Es vocal");
                    break;

                default:
                    Console.WriteLine("Otro carácter");
                    break;
            }
        }
    }
}
