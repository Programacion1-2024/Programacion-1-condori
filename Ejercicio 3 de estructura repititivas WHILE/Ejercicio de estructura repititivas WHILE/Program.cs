using System;

class Program
{
    static void Main(string[] args)
    {
        int cantidadnombres = 0;

        while (true)
        {
            Console.Write("Ingresa un nombre (o presiona Enter para terminar): ");
            string nombre = Console.ReadLine();

           
            if (string.IsNullOrEmpty(nombre))
            {
                break;
            }
            cantidadnombres++;
        }

        Console.WriteLine($"Se ingresaron {cantidadnombres} nombres.");
    }
}