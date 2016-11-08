using Engine.Modules.Regional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core
{
    public class Player
    {
        public string name;
        public Faction faction = null;

        public Player(string n, Faction f)
        {
            name = n;
            faction = f;
            faction.player = this;
        }

        public void update(double elapsedSeconds)
        {

        }
    }
}
