using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class Family
    {
        public HumanMale husband = null;
        public HumanFemale wife = null;
        public List<Human> childs = new List<Human>();
        public DateTime startDate;

        public Family(HumanMale h, HumanFemale w)
        {
            husband = h;
            wife = w;

            husband.family = this;
            wife.family = this;

            childs = new List<Human>();
            startDate = GameClock.currentTime;
        }

        public void addChild(Human ch)
        {
            ch.family = this;
            childs.Add(ch);
        }

        public void update(double elapsedSeconds)
        {
            updateWifeState();
        }

        private void updateWifeState()
        {
            if (wife.checkIsCanHasChilds())
                tryToInitPregnant();
        }

        private void tryToInitPregnant()
        {
            bool createPregnant = RandomGenerator.getRandomNumber(0.0, 1.0) < getPregnantPropability();
            if (createPregnant)
                wife.createPregnant();
        }

        private double getPregnantPropability()
        {
            return 0.7;
        }
    }
}
