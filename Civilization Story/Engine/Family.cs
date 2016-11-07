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

        }

        private void updateWifeState()
        {
            if (wife.isPregnant)
            {

            }
            else
            {

            }
        }
    }
}
