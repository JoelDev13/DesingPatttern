using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorAdapterSystem
{
    public class AdaptadorSensorTemperatura : ISensor
    {
        private SensorTemperatura _sensorTemperatura;

        public AdaptadorSensorTemperatura(SensorTemperatura sensorTemperatura)
        {
            _sensorTemperatura = sensorTemperatura;
        }

        public void MostrarDatos()
        {
            _sensorTemperatura.MostrarTemperatura();
        }
    }

}
