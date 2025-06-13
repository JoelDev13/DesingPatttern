using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDiarioTemperaturas
{
    internal class Temperatura
    {
        public DateTime fecha {  get; set; }
        public double valorTemperatura { get; set; }

        public Temperatura(DateTime fecha, double valorTemperatura)
        {
            this.fecha = fecha;
            this.valorTemperatura = valorTemperatura;
        }

        public override string ToString()
        {
            return string.Format("{0:dd/MM/yyyy} - {1}°C", fecha, valorTemperatura);
        }


    }
}
