using System;

class Program
{
    static void Main(string[] args)
    {
        int codigo = -1; 
        double precio;
        int cantidad;
        int codigoMayorCantidad = 0;
        int mayorCantidad = 0; 

       
        do
        {
            Console.Write("Ingrese el código del producto (1-10), 0 para terminar): ");
            if (int.TryParse(Console.ReadLine(), out codigo) && codigo >= 0 && codigo <= 10)
            {

                Console.Write("Ingrese el precio del producto: ");
                if (!double.TryParse(Console.ReadLine(), out precio) && precio < 0)
                {
                    Console.WriteLine("Precio inválido. Intente de nuevo.");
                                    }

                Console.Write("Ingrese la cantidad del producto: ");
                if (!int.TryParse(Console.ReadLine(), out cantidad) && cantidad < 0)
                {
                    Console.WriteLine("Cantidad inválida. Intente de nuevo.");
                    
                }

               
                if (cantidad > mayorCantidad)
                {
                    mayorCantidad = cantidad;
                    codigoMayorCantidad = codigo;
                }

            }
            else
            {
                Console.WriteLine("Código inválido. Intente de nuevo."); 
            }

        } while (codigo != 0); 

       
        if (codigoMayorCantidad != 0)
        {
            Console.WriteLine($"El producto con mayor cantidad es del Código {codigoMayorCantidad} y que tiene una Cantidad de {mayorCantidad}");
        }
        else
        {
            Console.WriteLine("No se ingresaron productos válidos.");
        }
    }
}
