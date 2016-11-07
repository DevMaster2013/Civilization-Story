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
            Human h = new Human(n, m, dop, null);
            humans.Add(h);
            return h;
        }

        public Family createFamily(Human hus, Human wife)
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
    }
}
