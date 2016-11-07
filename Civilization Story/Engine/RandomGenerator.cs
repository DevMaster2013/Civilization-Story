using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public static class RandomGenerator
    {
        private static Random doubleGenerator = new Random((int)DateTime.Now.Ticks);

        public static double getRandomNumber(double min, double max)
        {
            double range = max - min;
            return min + doubleGenerator.NextDouble() * range;
        }
    }
}
