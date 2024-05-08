using System;
class program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int numero = 0;
        int[] notas = new int[5];

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                notas[i] = numero;
            }
            else
            {
                Console.WriteLine("Entrada invalida, por favor ingrese de nuevo el valor");
            }
        }

        for (int i = 0; i < notas.Length; i++)
        {

            suma += notas[i];

        }

        double promedio =  suma / 5;

        Console.WriteLine($"El promedio de las notas ingresadas es : {promedio}")
    }
}