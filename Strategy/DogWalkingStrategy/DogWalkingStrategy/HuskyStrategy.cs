using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingStrategy
{
    public class HuskyStrategy : IPaseoStrategy
    {
        public int Tiempo => 60;
        public decimal Costo => 300m;
        public string Raza => "Husky Siberiano";
    }
}
