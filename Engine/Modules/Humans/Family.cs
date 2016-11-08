using Engine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Modules.Humans
{    
    public class Family
    {
        public HumanMale husband = null;
        public HumanFemale wife = null;
        public List<Human> childs = new List<Human>();
        public DateTime startDate;
        public bool isDivorced = false;
        public DateTime? endDate = null;

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
            checkFamilyState();
            updateWifeState();
        }

        private void updateWifeState()
        {
            if (wife.checkIsCanHasChilds() && !isDivorced && husband.isAlive && wife.isAlive)
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
            return husband.faction.humanManagement.pregnantPropbality;
        }

        private void checkFamilyState()
        {
            isDivorced = RandomGenerator.getRandomNumber(0, 1) < husband.faction.humanManagement.divorcePropbality;
            if (isDivorced)
                endDate = GameClock.currentTime;
        }
        
        public bool isInFamilyTree(Human h, bool includeMortals = true)
        {                 
            if ((h == husband || h == wife) && !isDivorced)
                return true;

            if (husband.parentFamily != null)
            {
                if (h == husband.parentFamily.husband || h == husband.parentFamily.wife)
                    return true;
                if (husband.isAlive || includeMortals)
                    if (husband.parentFamily.isInFamilyTree(h, includeMortals))
                        return true;
            }
            if (wife.parentFamily != null)
            {
                if (h == wife.parentFamily.husband || h == wife.parentFamily.wife)
                    return true;
                if (wife.isAlive || includeMortals)
                    if (wife.parentFamily.isInFamilyTree(h, includeMortals))
                        return true;
            }

            foreach (var child in childs)
                if (child == h)
                    return true;

            foreach (var child in childs)
                if (child.isAlive || includeMortals)
                    if (child.family != null)                    
                        if (child.family.isInFamilyTree(h, includeMortals))
                            return true;

            return false;
        }
    }
}
