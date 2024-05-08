using System;
class program
{
    static void Main(string[] args)
    {
        int valor = 0;
        List<int> numeros = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out valor))
            {
                numeros.Add(valor);
            }
            else
            {
                Console.WriteLine("Entrada invalida, por favor ingrese de nuevo otro valor");
            }
        }
        foreach (int numero in numeros)
        {
            Console.WriteLine($"El numero ingresado es: {numero}");
        }
    }

}
