using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingStrategy
{
    public class Paseador
    {
        private IPaseoStrategy _strategy;

        public void SetStrategy(IPaseoStrategy strategy)
        {
            _strategy = strategy;
        }

        public void MostrarPaseo()
        {
            Console.WriteLine($"Raza: {_strategy.Raza}");
            Console.WriteLine($"Tiempo del paseo: {_strategy.Tiempo} minutos");
            Console.WriteLine($"Costo: RD${_strategy.Costo}");
        }
    }
}
