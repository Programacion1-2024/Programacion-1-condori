using System;
class program
{
    static void Main(string[] args)
    {
        double promedio = 0;
        int suma = 0;
        int numero = 0;
        int contador = 0;
        do
        {
            Console.WriteLine("Ingrese un numero: ");

            if (int.TryParse(Console.ReadLine(), out numero) && numero < 0)
            {
                suma += numero;
                contador++;

            }

        } while (numero < 0);

        if (contador > 0)
        {
            promedio = suma / contador;

        }
     
        Console.WriteLine($"El promedio de los numeros negativos es: {promedio} ");
    }
}
