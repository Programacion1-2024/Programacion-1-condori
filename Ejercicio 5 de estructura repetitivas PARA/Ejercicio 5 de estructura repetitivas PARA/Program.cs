using System;
class program
{
    static void Main(string[] args)
    {
        double mayorgasto = 0;
        string clientemayorgasto = "";
        for (int contador = 1; contador <= 5; contador++)
        {
            Console.WriteLine($"Ingrese el nombre del cliente {contador}: ");
            string nombrecliente = Console.ReadLine();

            Console.WriteLine($"Ingrese el total gastado por {nombrecliente}: ");

            if (double.TryParse(Console.ReadLine(), out double numero))
            {

                if (numero > mayorgasto)
                {
                    mayorgasto = numero;
                    clientemayorgasto = nombrecliente;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
                contador--;
            }
        }

        Console.WriteLine($"El cliente {clientemayorgasto} es el que mayor gasto tuvo.");
        
    }


}
    