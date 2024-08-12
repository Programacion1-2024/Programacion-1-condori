using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número para calcular su factorial:");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            if (n > 0)
            {
                int factorial = 1;
                for (int contador = 1; contador <= n; contador++)
                {
                    factorial = factorial * contador;
                }
                Console.WriteLine($"El factorial de {n} es: {factorial}");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
}
