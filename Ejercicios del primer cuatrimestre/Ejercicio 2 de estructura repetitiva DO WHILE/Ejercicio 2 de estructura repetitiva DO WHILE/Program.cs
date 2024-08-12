using System;
class program
{
  static void Main(string[] args)
  {
        int numero = 0;
        do
        {
            Console.WriteLine("Ingrese un numero: ");

            if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
            {
                Console.WriteLine("El numero ingresado es positivo");
            }
            else
            { 
                Console.WriteLine("Entrada invalida, por favor ingrese un numero");
                numero = -1;
            }
        
        } while (numero < 0)


  }


}
