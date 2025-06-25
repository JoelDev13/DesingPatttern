using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorEstudiantes
{
    public class ExportadorTXT : IExportador
    {
        public void Exportar(Estudiante estudiante, string rutaArchivo)
        {
            string contenido = $"Matrícula: {estudiante.Matricula}{Environment.NewLine}" +
                               $"Nombre: {estudiante.Nombre}{Environment.NewLine}" +
                               $"Carrera: {estudiante.Carrera}{Environment.NewLine}" +
                               "------------------------" + Environment.NewLine;

            File.AppendAllText(rutaArchivo, contenido);
        }
    }
}
