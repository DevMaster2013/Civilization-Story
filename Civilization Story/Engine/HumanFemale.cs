using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class HumanFemale : Human
    {
        public bool isPregnant;
        public DateTime? lastDatePregnenat = null;

        public HumanFemale(string n, DateTime dop, Family f)
            : base(n, false, dop, f)
        {
            isPregnant = false;
        }

        public override void update(double elapsedSeconds)
        {

        }

        public override bool checkIsCanHasChilds()
        {
            if (isPregnant)
                return false;

            if (lastDatePregnenat == null)
                return true;

            TimeSpan elapsedFromLastPregnant = GameClock.currentTime - lastDatePregnenat.Value;
            if (elapsedFromLastPregnant < GameSettings.minAllowedTimeBetweenEachPregnant)
                return false;

            return true;
        }
    }
}
