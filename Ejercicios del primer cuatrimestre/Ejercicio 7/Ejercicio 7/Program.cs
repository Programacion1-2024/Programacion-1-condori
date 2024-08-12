using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese el primer numero");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo numero");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        
        if (numero1 > numero2)
        {
            Console.WriteLine("El mayor número es: " + numero1);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("El mayor número es: " + numero2);
        }
        else
        {
            Console.WriteLine("Ambos números son iguales.");
        }
    }
}
