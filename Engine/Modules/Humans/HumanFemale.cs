using Engine.Modules.Regional;
using Engine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Modules.Humans
{
    public class HumanFemale : Human
    {
        public Pregnant currentPregnant = null;

        public HumanFemale(string n, DateTime dop, Family f, Faction fac)
            : base(n, false, dop, f, fac)
        {
        }

        public override bool update(double elapsedSeconds)
        {
            if (!base.update(elapsedSeconds)) return false;
            if (currentPregnant != null && !currentPregnant.isDone)
                currentPregnant.update(elapsedSeconds);
            return true;
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
                h.parentFamily = family;
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
            if (elapsedFromLastPregnant < faction.humanManagement.minAllowedTimeBetweenEachPregnant)
                return false;

            return true;
        }

        public override bool isCanMarry()
        {
            if (!base.isCanMarry())
                return false;
            return age > TimeSpan.FromDays(faction.humanManagement.minFemaleMarriageAge * 356);
        }

        public bool canAcceptMarriage(HumanMale hus)
        {
            if (faction.humanManagement.isForbiddenToMarry(hus, this))
                return false;
            return RandomGenerator.getRandomNumber(0, 1) < faction.humanManagement.marriageWishRatio;
        }
    }
}
