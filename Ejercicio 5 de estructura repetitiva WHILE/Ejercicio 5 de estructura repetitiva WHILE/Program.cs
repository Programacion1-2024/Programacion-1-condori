using System;
class program
{
    static void Main(string[] args)
    {
        double costounitario = 0;
        int cantidadcomprada = 1;
        double deudatotal = 0;
        int numero = 1;
        
        while (cantidadcomprada != 0)
        {
            Console.WriteLine($"Producto {numero}");
              Console.WriteLine("Ingrese la cantidad comprada del producto: ");
            if (int.TryParse(Console.ReadLine(), out cantidadcomprada))
            {
               
                Console.WriteLine("Ingrese su costo unitario: ");
                if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out costounitario))
                {
                    double compratotal = costounitario * cantidadcomprada;
                    deudatotal += compratotal;
                    numero++;
                }
                else
                {
                    Console.WriteLine("Cantidad comprada invalida. Intente nuevamente: ");

                }
            }
            else
            {
                Console.WriteLine("Costo unitario invalido. Intente nuevamente");

            }

        }
        Console.WriteLine($"El total adeudado del cliente  es: {deudatotal}");
    }

}