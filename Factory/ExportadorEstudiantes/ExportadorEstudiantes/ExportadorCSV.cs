using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorEstudiantes
{
    public class ExportadorCSV : IExportador
    {
        private bool archivoExiste = false;

        public void Exportar(Estudiante estudiante, string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
            {
                File.AppendAllText(rutaArchivo, "Matricula,Nombre,Carrera" + Environment.NewLine);
            }

            string contenido = $"{estudiante.Matricula},{estudiante.Nombre},{estudiante.Carrera}{Environment.NewLine}";

            File.AppendAllText(rutaArchivo, contenido);
        }
    }
}
