using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
        double longitudLado = Convert.ToDouble(Console.ReadLine());

        
        double area = longitudLado * longitudLado;

        Console.WriteLine($"El área del cuadrado con longitud de lado {longitudLado} es: {area}");

    }
}
