using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorEstudiantes
{
    public interface IExportador
    {
        void Exportar(Estudiante estudiante, string rutaArchivo);
    }

}
