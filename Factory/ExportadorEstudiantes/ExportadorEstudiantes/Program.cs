
using ExportadorEstudiantes;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la matrícula:");
        string matricula = Console.ReadLine();

        Console.WriteLine("Ingrese el nombre:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la carrera:");
        string carrera = Console.ReadLine();

        Estudiante estudiante = new Estudiante
        {
            Matricula = matricula,
            Nombre = nombre,
            Carrera = carrera
        };

        Console.WriteLine("Seleccione el formato para exportar (txt, csv, json):");
        string formato = Console.ReadLine();

        try
        {
            IExportador exportador = ExportadorFactory.CrearExportador(formato);
            string rutaArchivo = ExportadorFactory.ObtenerRutaArchivo(formato);

            exportador.Exportar(estudiante, rutaArchivo);

            Console.WriteLine($"Archivo guardado correctamente en '{rutaArchivo}'");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
