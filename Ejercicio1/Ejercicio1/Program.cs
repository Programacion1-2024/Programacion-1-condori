using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo número:");
        string input2 = Console.ReadLine();

        
        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
        {
          
            double suma = num1 + num2;


            Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese números válidos.");
        }
    }
}
