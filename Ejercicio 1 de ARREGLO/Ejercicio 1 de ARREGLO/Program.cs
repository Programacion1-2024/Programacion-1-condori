using System;
class program
{    
    static void Main(string[] args)
    {
        int numero = 0;
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                numeros[i] = numero;
            }
            else
            {
                Console.WriteLine("Entrada invalida, por favor ingrese de nuevo el valor");
            }
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Los numeros ingresados son: {numeros[i]}");
        }

    }

}