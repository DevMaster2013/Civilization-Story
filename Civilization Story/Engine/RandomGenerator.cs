using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public static class RandomGenerator
    {
        private static Random randomGenerator = new Random((int)DateTime.Now.Ticks);

        public static double getRandomNumber(double min, double max)
        {
            double range = max - min;
            return min + randomGenerator.NextDouble() * range;
        }

        public static TimeSpan getRandomTimeSpan(TimeSpan start, TimeSpan end)
        {
            double seconds = getRandomNumber(start.TotalSeconds, end.TotalSeconds);
            return TimeSpan.FromSeconds(seconds);
        }

        public static string getRandomName(bool isMale)
        {
            if (isMale)
            {
                int num = randomGenerator.Next(0, NameDatabase.maleNames.Count - 1);
                return NameDatabase.maleNames[num];
            }
            else
            {
                int num = randomGenerator.Next(0, NameDatabase.femaleNames.Count - 1);
                return NameDatabase.femaleNames[num];
            }
        }
    }
}
