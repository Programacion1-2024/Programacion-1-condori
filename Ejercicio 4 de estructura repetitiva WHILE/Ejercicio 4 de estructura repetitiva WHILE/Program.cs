using System;
class program
{
    static void Main(string[] args)
    {
        double costounitario = 1;
        int cantidadcomprada = 0;
        double deudatotal = 0;

        while (costounitario != 0)
        {
            
            Console.WriteLine("Ingrese el costo unitario: ");
            if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out costounitario))
            { 
                Console.WriteLine("Ingrese la cantidad comprada: ");

                if (int.TryParse(Console.ReadLine(), out cantidadcomprada))
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
                
            }

        }
        Console.WriteLine($"El total adeudado es: {deudatotal}");
    }

}