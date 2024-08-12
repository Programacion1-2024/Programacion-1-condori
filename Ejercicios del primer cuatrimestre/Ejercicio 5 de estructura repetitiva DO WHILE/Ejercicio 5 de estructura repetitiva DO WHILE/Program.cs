using System;
class program
{
    static void Main(string[] args)
    {
        int contador = 0;
        double suma = 0;
        int numero = 0;
        double promedio = 0;
        do
        {
            Console.WriteLine("Ingrese un numero: ");

            if (int.TryParse(Console.ReadLine(), out numero) && numero < 1000)
            {
                suma += numero;
                contador++;

            }
            else
            {
                promedio = suma / contador;
            }


        } while (numero < 1000);

        Console.WriteLine($"El promedio de los numeros es: {promedio}");
    }
}