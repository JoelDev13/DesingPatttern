using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingStrategy
{
    public interface IPaseoStrategy
    {
        int Tiempo { get; }
        decimal Costo { get; }
        string Raza { get; }
    }

}
