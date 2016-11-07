using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class HumanFemale : Human
    {
        public Pregnant currentPregnant = null;

        public HumanFemale(string n, DateTime dop, Family f)
            : base(n, false, dop, f)
        {
        }

        public override void update(double elapsedSeconds)
        {
            if (currentPregnant != null && !currentPregnant.isDone)
                currentPregnant.update(elapsedSeconds);
        }

        public void createPregnant()
        {
            currentPregnant = new Pregnant(this);
            currentPregnant.onPregnantComplete += CurrentPregnant_onPregnantComplete;
        }

        private void CurrentPregnant_onPregnantComplete(Pregnant pregnant, bool succeeded)
        {
            if (succeeded)
            {
                Human h = faction.createHuman(RandomGenerator.getRandomName(pregnant.isMale), pregnant.endDate, pregnant.isMale);
                family.childs.Add(h);
            }
        }

        public override bool checkIsCanHasChilds()
        {
            if (!base.checkIsCanHasChilds())
                return false;

            if (currentPregnant == null)
                return true;

            if (currentPregnant != null && !currentPregnant.isDone)
                return false;

            TimeSpan elapsedFromLastPregnant = GameClock.currentTime - currentPregnant.endDate;
            if (elapsedFromLastPregnant < GameSettings.minAllowedTimeBetweenEachPregnant)
                return false;

            return true;
        }
    }
}
