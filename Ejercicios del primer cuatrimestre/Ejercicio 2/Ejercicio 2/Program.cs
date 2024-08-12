using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero:");

        int numero = int.Parse(Console.ReadLine());

       
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número ingresado es par.");
        }
        else
        {
            Console.WriteLine("El número ingresado es impar.");
        }

    }
}





}