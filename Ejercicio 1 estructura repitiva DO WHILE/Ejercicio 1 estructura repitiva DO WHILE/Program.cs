using System;
class program
{
    static void Main(string[] args)
    {
        int contraseña = 0;

        do
        {
            Console.Write("Nombre de usuario: ");
            Console.ReadLine();

            Console.Write("Clave: ");
            if (int.TryParse(Console.ReadLine(), out contraseña) && contraseña == 667788)
            {
                Console.WriteLine("Sesión iniciada correctamente");
            }
            else
            {
                Console.WriteLine("Clave incorrecta.");
            }

        } while (contraseña != 667788);
    }

}