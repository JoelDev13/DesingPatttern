using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExportadorEstudiantes
{
    public class ExportadorJSON : IExportador
    {
        private string rutaArchivo;

        public ExportadorJSON(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }

        public void Exportar(Estudiante estudiante, string rutaArchivo = null)
        {
            // Si nos pasan rutaArchivo, usamos esa, sino la del constructor
            string path = rutaArchivo ?? this.rutaArchivo;

            List<Estudiante> estudiantes = new List<Estudiante>();

            if (File.Exists(path))
            {
                string jsonExistente = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(jsonExistente))
                {
                    estudiantes = JsonSerializer.Deserialize<List<Estudiante>>(jsonExistente);
                }
            }

            estudiantes.Add(estudiante);

            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(estudiantes, opciones);

            File.WriteAllText(path, jsonString);
        }
    }
}
