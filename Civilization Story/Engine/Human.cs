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

        public Human(string n, bool m, DateTime dob, Family f)
        {
            name = n;
            dateOfBirth = dob;
            isMale = m;
            family = f;
            isAlive = true;
        }
    }
}
