using RegistroDiarioTemperaturas;

class Program
{
    static void Main()
    {
        string opcion = "";
        var gestor = GestorTemperaturas.getGestorTemperatura();

        while (opcion != "3")
        {
            Console.Clear();
            Console.WriteLine("=== Sistema Registro de temperatura diaria ===");
            Console.WriteLine("1 Registrar Temperatura");
            Console.WriteLine("2 Ver registros");
            Console.WriteLine("3 Salir");
            Console.Write("Selecciona una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": gestor.RegistrarTemperatura(); break;
                case "2": gestor.MostrarRegistros(); break;
                case "3": Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción inválida"); break;
            }

            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}

