using System;
class program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int numero = 0;
        do
        {
            Console.WriteLine("Ingrese un numero: ");

            if (int.TryParse(Console.ReadLine(), out numero) && numero < 1000)
            {
                suma += numero;

            }
            else
            {
                Console.WriteLine($"La suma de los numeros es: {suma}");
            }
  

        } while (numero < 1000);
    }
}
