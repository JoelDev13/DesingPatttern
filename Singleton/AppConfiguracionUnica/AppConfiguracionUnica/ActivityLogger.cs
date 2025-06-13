using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityLoggerApp
{
     class ActivityLogger
    {
        private ActivityLogger() { }
        private static ActivityLogger _instance;
        private List<string> _logs = new List<string>();

        public static ActivityLogger Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ActivityLogger();
                return _instance;
            }
        }

        public void Log() 
        {
            DateTime fechaHora = DateTime.Now;
            string hora = fechaHora.ToString("dd/MM/yyyy HH:mm:ss");

            _logs.Add($"{fechaHora} Usuario 'admin' inició sesión");
            _logs.Add($"{fechaHora} Base de datos conectada");
            _logs.Add($"{fechaHora} Interfaz cargada correctamente");

        }

        public void ShowLog()
        {
            foreach (String salida in _logs)
            {
                Console.WriteLine(salida);
            }
        }




    }
}



