using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingStrategy
{
    public class LabradorStrategy : IPaseoStrategy
    {
        public int Tiempo => 40;
        public decimal Costo => 200m;
        public string Raza => "Labrador";
    }
}
