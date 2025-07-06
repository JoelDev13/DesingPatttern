using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingStrategy
{
    public class StrategyFactory
    {
        public static IPaseoStrategy GetStrategy(string raza)
        {
            return raza.ToLower() switch
            {
                "chihuahua" => new ChihuahuaStrategy(),
                "labrador" => new LabradorStrategy(),
                "husky siberiano" => new HuskyStrategy(),
                _ => null
            };
        }
    }
}
