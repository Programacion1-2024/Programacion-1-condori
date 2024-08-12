

using System;
class program
{
    static void Main(string[] args)
    {
        int input = 1;
        List<int> numeros = new List<int>();
        while (input != 0)
        {
            Console.WriteLine("Ingrese un numero (0 para finalizar): ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                numeros.Add(input);
            }
        }
        numeros.Sort();
        if (numeros.Count > 0 )
        {
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
        else
        {
            Console.WriteLine("Entrada invalida, por favor ingrese un nuevo valor");
        }
    }   

}