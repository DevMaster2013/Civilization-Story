using Engine.Modules.Regional;
using Engine.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Modules.Humans
{
    public class Human
    {
        public string name;
        public DateTime dateOfBirth;
        public bool isMale;
        public Family family = null;
        public Family parentFamily = null;
        public bool isAlive = true;
        public bool canHasChilds = true;
        public Faction faction = null;
        public Settlement settlement = null;
        public TimeSpan maxAge;        

        public Human(string n, bool m, DateTime dob, Family f, Faction fac)
        {
            name = n;
            dateOfBirth = dob;
            isMale = m;
            family = f;
            isAlive = true;
            faction = fac;
            settlement = null;
            computeMaximumAge();
            canHasChilds = RandomGenerator.getRandomNumber(0.0, 1.0) < getCanHasChildsPropability();
        }

        public virtual bool update(double elapsedSeconds)
        {
            if (isAlive)
            {
                if (GameClock.currentTime - dateOfBirth >= maxAge)
                {
                    isAlive = false;
                    return false;
                }
            }
            return true;
        }

        private double getCanHasChildsPropability()
        {
            return faction.humanManagement.fertilityPropability;
        }

        public virtual bool checkIsCanHasChilds()
        {
            if (!isAlive)
                return false;
            if (!canHasChilds)
                return false;

            if (family == null)
                return false;

            return true;
        }

        public TimeSpan age
        {
            get { return GameClock.currentTime - dateOfBirth; }
        }

        public void computeMaximumAge()
        {
            int averageAge = faction.humanManagement.averageAge;
            double ageProp = RandomGenerator.getRandomNumber(0.0, 1.5);
            maxAge = TimeSpan.FromDays(ageProp * averageAge * 356);
        }

        public virtual bool isCanMarry()
        {
            if (family != null && !family.isDivorced && family.husband.isAlive && family.wife.isAlive) return false;

            return true;
        }
    }
}
