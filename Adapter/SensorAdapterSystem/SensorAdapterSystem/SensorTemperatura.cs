using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorAdapterSystem
{
    public class SensorTemperatura
    {
        public double temperaturaCelsius {  get; set; }

        public void MostrarTemperatura() {
            Console.WriteLine($"La temperatura estan en: {temperaturaCelsius} celsius");
        }
    }
}
