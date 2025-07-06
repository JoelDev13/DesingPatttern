using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingStrategy
{
    public class ChihuahuaStrategy : IPaseoStrategy
    {
        public int Tiempo => 20;
        public decimal Costo => 100m;
        public string Raza => "Chihuahua";
    }
2
}
