using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class Faction
    {
        public string name;
        public List<Family> families = new List<Family>();
        public List<Human> humans = new List<Human>();
        public List<Settlement> settlements = new List<Settlement>();
        public Human founder = null;
        public Player player = null;
        public World world = null;

        public Faction(string n, World w)
        {
            name = n;
            player = null;
            world = w;
        }

        public Human createHuman(string n, DateTime dop, bool m)
        {
            Human h;
            if (m) h = new HumanMale(n, dop, null);
            else h = new HumanFemale(n, dop, null);
            h.faction = this;

            humans.Add(h);
            return h;
        }

        public Family createFamily(HumanMale hus, HumanFemale wife)
        {
            Family f = new Family(hus, wife);
            families.Add(f);
            return f;
        }

        public Settlement createSettlement(string n)
        {
            Settlement s = new Settlement(n, this);
            settlements.Add(s);
            return s;
        }

        public void update(double elapsedSeconds)
        {
            foreach (var family in families.ToArray())
                family.update(elapsedSeconds);
            foreach (var human in humans.ToArray())
                human.update(elapsedSeconds);
            foreach (var settlement in settlements.ToArray())
                settlement.update(elapsedSeconds);
        }
    }
}
