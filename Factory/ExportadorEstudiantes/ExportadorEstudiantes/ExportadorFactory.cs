using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorEstudiantes
{
    public static class ExportadorFactory
    {
        private static string rutaBase = @"C:\Users\la\Desktop\Programacion\Mi roadmap backend\Patrones De Diseños c#\Factory\ExportadorEstudiantes\ExportadorEstudiantes";

        public static IExportador CrearExportador(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "txt":
                    return new ExportadorTXT();
                case "csv":
                    return new ExportadorCSV();
                case "json":
                    string rutaJson = Path.Combine(rutaBase, "estudiante.json");
                    return new ExportadorJSON(rutaJson);
                default:
                    throw new ArgumentException("Formato no soportado.");
            }
        }

        public static string ObtenerRutaArchivo(string tipo)
        {
            return Path.Combine(rutaBase, $"estudiante.{tipo.ToLower()}");
        }
    }

}
