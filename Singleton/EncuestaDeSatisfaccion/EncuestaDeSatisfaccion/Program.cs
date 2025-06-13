
using EncuestaDeSatisfaccion;

class Program
{
    static void Main()
{
    string opcion = "";
    

    while (opcion != "3")
    {
        Console.Clear();
        Console.WriteLine("=== Sistema de encuesta ===");
        Console.WriteLine("1 Agregar una encuesta");
        Console.WriteLine("2 Ver todas las encuestas");
        Console.WriteLine("3 Salir");
        Console.Write("Selecciona una opción: ");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1": GestorEncuesta.GetInstance().RegistrarEncuestaa(); break;
            case "2": GestorEncuesta.GetInstance().MostrarEncuesta(); ; break;
            case "3": Console.WriteLine("Saliendo..."); break;
            default: Console.WriteLine("Opción inválida"); break;
        }

        Console.WriteLine("\nPresiona una tecla para continuar...");
        Console.ReadKey();
    }
}
}
