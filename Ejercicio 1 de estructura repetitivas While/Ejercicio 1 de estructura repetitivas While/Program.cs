using System;
class program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int valoringresado = 1;
       
        while (valoringresado != 0)
        {
            Console.Write($"Ingrese un valor {valoringresado}: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                suma += +numero;

                
            }
            else
            {

                Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
            }
            valoringresado++;
            
        }
        Console.WriteLine($"La suma de los valores es: {suma}");
    }

}