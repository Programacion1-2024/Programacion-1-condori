using System;
using System.Diagnostics.CodeAnalysis;
class program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int valor = 0;
        List<int> numeros = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out valor))
            {
                numeros.Add(valor);
            }
            else
            {
                Console.WriteLine("Entrada invalida, por favor ingrese de nuevo otro valor");
            }
        }
        foreach (int numero in numeros)
        {
            suma += numero;

        }
        double promedio = suma / 5;
        Console.WriteLine($"El promedio de las notas ingresadas es: {promedio}");
    }
}
