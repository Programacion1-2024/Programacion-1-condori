public class Singleton
{
    private static Singleton instance;

    // El constructor es privado para evitar que se pueda instanciar la clase desde fuera
    private Singleton() { }

    // Método para obtener la única instancia de la clase
    public static Singleton GetInstance()
    {
        // Si la instancia no ha sido creada, la creamos
        if (instance == null)
        {
            instance = new Singleton();
        }
        // Devolvemos la instancia
        return instance;
    }

    // Método para imprimir un mensaje que demuestra que el Singleton está funcionando
    public void PrintMessage()
    {
        Console.WriteLine("Soy un Singleton");
    }
}
