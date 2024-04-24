
using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese 8 valores enteros");

        double mayor = 0;
        for (int i = 1; i <= 8; i++)

        {
            Console.Write($"Valor {i}: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
              
                if (numero > mayor)
                {
                    mayor = numero; 
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
                i--;
            }

        }

       Console.WriteLine("El número mayor es: {0}", mayor);

        


    }










}