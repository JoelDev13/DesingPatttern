using DogWalkingStrategy;

class Program
{
    static void Main()
    {
        var paseador = new Paseador();

        Console.WriteLine("=== PASEADOR DE MASCOTAS ===");
        Console.WriteLine("Seleccione la raza del perro:");
        Console.WriteLine("1. Chihuahua");
        Console.WriteLine("2. Labrador");
        Console.WriteLine("3. Husky Siberiano");
        Console.Write("Ingrese una opcion");

        string opcion = Console.ReadLine();

        string raza = opcion switch
        {
            "1" => "chihuahua",
            "2" => "labrador",
            "3" => "husky siberiano",
            _ => null
        };

        if (raza != null)
        {
            var strategy = StrategyFactory.GetStrategy(raza);
            paseador.SetStrategy(strategy);

            Console.WriteLine("\n=== INFORMACION DEL PASEO ===");
            paseador.MostrarPaseo();
        }
        else
        {
            Console.WriteLine("Opcion no valida, Por favor seleccione 1, 2 o 3");
        }
    }
}