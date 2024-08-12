using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero positivo para mostrar los números pares hasta ese número:");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            if (n >= 0)
            {
                Console.WriteLine($"Números pares hasta {n}:");
                for (int i = 0; i <= n; i += 2)
                {
                    Console.WriteLine(i);
                }
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
