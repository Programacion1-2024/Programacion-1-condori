using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Ingresa un número: ");
        string input = Console.ReadLine();

        int numero;
        if (int.TryParse(input, out numero))
        {
            
            if (numero >= 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else
            {
                Console.WriteLine("El número es negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número válido.");
        }
    }
}

        
        
        
        
        
        
        
        
    }






  }













}