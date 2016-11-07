using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class World
    {
        public List<Faction> factions = new List<Faction>();

        public Faction createFaction(string name)
        {
            Faction f = new Faction(name, this);
            factions.Add(f);
            return f;
        }

        public void update(double elapsedSeconds)
        {
            foreach (var faction in factions)
                faction.update(elapsedSeconds);
        }
    }
}
