using System;
using System.Text.Json;
using System.IO;
using CifradoApp;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Introduce tu correo electrónico: ");
        string correo = Console.ReadLine();

        Console.Write("Introduce tu clave: ");
        string clave = Console.ReadLine();

        ICifrador cifrador = CifradorFactory.Crear(correo);
        if (cifrador == null)
        {
            Console.WriteLine("Dominio no soportado");
            return;
        }

        string claveCifrada = cifrador.Cifrar(clave);

        var usuario = new Usuario
        {
            Correo = correo,
            ClaveCifrada = claveCifrada
        };

        string json = JsonSerializer.Serialize(usuario, new JsonSerializerOptions { WriteIndented = true });

        string filePath = @"C:\Users\la\Desktop\Programacion\Mi roadmap backend\Patrones De Diseños c#\Factory\CifradoApp\CifradoApp\usuarios.json";

        File.AppendAllText(filePath, json + Environment.NewLine);
        Console.WriteLine($"Usuario guardado correctamente");

    }
}
