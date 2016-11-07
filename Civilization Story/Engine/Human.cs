using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class Human
    {
        public string name;
        public DateTime dateOfBirth;
        public bool isMale;
        public Family family = null;
        public bool isAlive = true;
        public bool canHasChilds = true;

        public Human(string n, bool m, DateTime dob, Family f)
        {
            name = n;
            dateOfBirth = dob;
            isMale = m;
            family = f;
            isAlive = true;

            canHasChilds = RandomGenerator.getRandomNumber(0.0, 1.0) < getCanHasChildsPropability();
        }

        public virtual void update(double elapsedSeconds)
        {
            
        }

        private double getCanHasChildsPropability()
        {
            return 0.9;
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
    }
}
