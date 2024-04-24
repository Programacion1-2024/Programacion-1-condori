using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los datos de las 5 compras");

        double deudatotal = 0;

        for (int contador = 1; contador <= 5; contador++)
        {
            Console.WriteLine($"compra {contador}: ");
            Console.WriteLine("Ingrese el costo unitario: ");
            if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double costounitario))
            {
                Console.WriteLine("Ingrese la cantidad comprada: ");

                if (int.TryParse(Console.ReadLine(), out int cantidadcomprada))
                {
                    double compratotal = costounitario * cantidadcomprada;
                    deudatotal += compratotal;
                }
                else
                {
                    Console.WriteLine("Cantidad comprada invalida. Intente nuevamente: ");
                }
            }
            else
            {
                Console.WriteLine("Costo unitario invalido. Intente nuevamente");
                contador--;
            }
        }
        Console.WriteLine($"El total adeudado es: {deudatotal}");














    }













}