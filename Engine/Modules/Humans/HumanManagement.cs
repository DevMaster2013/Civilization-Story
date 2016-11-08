using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Modules.Humans
{
    public class HumanManagement
    {
        public List<Human> humans = null;

        public TimeSpan minAllowedTimeBetweenEachPregnant = TimeSpan.FromDays(70.0);
        public double   savePregnantPropability = 0.95;
        public double   pregnantPropbality = 0.7;
        public int      averageAge = 80;
        public double   fertilityPropability = 0.98;
        public int      minMaleMarriageAge = 16;
        public int      minFemaleMarriageAge = 16;
        public double   marriageWishRatio = 0.95;
        public double   divorcePropbality = 0.00001;

        public HumanManagement(List<Human> h)
        {
            humans = h;
        }
    
        public List<HumanMale> getMaleHumans()
        {
            List<HumanMale> maleHumans = new List<HumanMale>();
            foreach (Human h in humans)
            {
                if (h.isMale)
                    maleHumans.Add(h as HumanMale);
            }
            return maleHumans;
        }

        public List<HumanFemale> getFemaleHumans()
        {
            List<HumanFemale> femaleHumans = new List<HumanFemale>();
            foreach (Human h in humans)
            {
                if (!h.isMale)
                    femaleHumans.Add(h as HumanFemale);
            }
            return femaleHumans;
        }

        public List<Human> getLiveHumans()
        {
            List<Human> hs = new List<Human>();
            foreach (Human h in humans)
            {
                if (h.isAlive)
                    hs.Add(h);
            }
            return hs;
        }

        public List<Human> getMortalHumans()
        {
            List<Human> hs = new List<Human>();
            foreach (Human h in humans)
            {
                if (!h.isAlive)
                    hs.Add(h);
            }
            return hs;
        }

        public List<HumanFemale> getSingleFemales()
        {
            List<HumanFemale> femaleHumans = new List<HumanFemale>();
            foreach (Human h in humans)
            {
                if (!h.isMale && h.isAlive && h.isCanMarry())
                    femaleHumans.Add(h as HumanFemale);
            }
            return femaleHumans;
        }

        public List<HumanMale> getSingleMales()
        {
            List<HumanMale> maleHumans = new List<HumanMale>();
            foreach (Human h in humans)
            {
                if (h.isMale && h.isAlive && h.isCanMarry())
                    maleHumans.Add(h as HumanMale);
            }
            return maleHumans;
        }        

        public bool isForbiddenToMarry(Human pHus, Human pWife)
        {
            if (pHus.family != null)
            {
                if (pHus.family.isInFamilyTree(pWife, false))
                    return true;
            }
            else if (pWife.family != null)
            {
                if (pWife.family.isInFamilyTree(pHus, false))
                    return true;
            }

            if (pHus.parentFamily != null)
            {
                if (pHus.parentFamily.isInFamilyTree(pWife, false))
                    return true;
            }
            else if (pWife.parentFamily != null)
            {
                if (pWife.parentFamily.isInFamilyTree(pHus, false))
                    return true;
            }

            return false;
        }
    }
}
