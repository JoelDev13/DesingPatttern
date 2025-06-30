using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorAdapterSystem
{
    public class AdaptadorSensorPresion :ISensor
    {
        private SensorPresion _sensorPresion;

        public AdaptadorSensorPresion(SensorPresion sensorPresion)
        {
            _sensorPresion = sensorPresion;
        }
        public void MostrarDatos() {
            Console.WriteLine($"La presion es de {_sensorPresion.obtenerPresion()} pascal");
        }

    }
}
