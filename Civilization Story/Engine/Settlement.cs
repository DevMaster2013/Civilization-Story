using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class Settlement
    {
        public string name;
        public Faction faction = null;
        public Human governer = null;

        public Settlement(string n, Faction f)
        {
            name = n;
            faction = f;
        }
    }
}
