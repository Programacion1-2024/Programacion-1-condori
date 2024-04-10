using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo número:");
        string input2 = Console.ReadLine();

        Console.WriteLine("Ingrese el tercer número:");
        string input3 = Console.ReadLine();


        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2) && double.TryParse(input3, out double num3))
        {
            double promedio = (num1 + num2 + num3) / 3;

            Console.WriteLine($"El promedio de los numeros son: {promedio}");
        }
        else
        {
            Console.WriteLine("Los numeros ingresados son invalidos, por favor ingrese nuevos numeros");
        }

    }





}
