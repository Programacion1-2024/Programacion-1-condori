using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese 8 valores enteros");

        int suma = 0;
             for (int i = 1; i <= 8; i++)
             {
                Console.Write($"Valor {i}: ");

                  if (int.TryParse(Console.ReadLine(), out int numero))
                  {

                      suma += numero;
                  }
                  else
                  {

                    Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
                  }
              }

        double promedio = suma / 8;


        Console.WriteLine("El promedio de los números ingresados es: {0}", promedio);

    }

}

