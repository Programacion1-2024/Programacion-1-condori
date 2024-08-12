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

                if (numero == 0)
                {
                    break;
                }
            }
            else
            {

                Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
            }
            valoringresado++;

        
        }

        if (valoringresado > 0)
        {
            double promedio = (double)suma / valoringresado;

            Console.WriteLine($"El promedio de los valores es: {promedio}");
        }
        else
        {
            Console.WriteLine("No se ingresaron valores.");
        }
    }

}