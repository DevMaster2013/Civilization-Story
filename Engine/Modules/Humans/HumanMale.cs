using Engine.Modules.Regional;
using Engine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Modules.Humans
{
    public class HumanMale : Human
    {
        public HumanMale(string n, DateTime dop, Family f, Faction fac)
            : base(n, true, dop, f, fac)
        {

        }

        public override bool update(double elapsedSeconds)
        {
            if (!base.update(elapsedSeconds))
                return false;

            if (isCanMarry())
                tryToProposeMarriage();

            return true;
        }

        public override bool isCanMarry()
        {
            if (!base.isCanMarry())
                return false;
            return age > TimeSpan.FromDays(faction.humanManagement.minMaleMarriageAge * 356);
        }

        private void tryToProposeMarriage()
        {
            List<HumanFemale> singleFemales = faction.humanManagement.getSingleFemales();
            if (singleFemales.Count <= 0) return;

            int randomIndex = RandomGenerator.getRandomInt(0, singleFemales.Count - 1);
            bool foundWife = singleFemales[randomIndex].canAcceptMarriage(this);
            if (foundWife)
                faction.createFamily(this, singleFemales[randomIndex]);
        }

    }
}
