using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer lado del triangulo: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo lado del triangulo: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer lado del triangulo: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        double perimetro = lado1 + lado2 + lado3;

        
        Console.WriteLine("El perímetro del triángulo es: " + perimetro);
    }
}

