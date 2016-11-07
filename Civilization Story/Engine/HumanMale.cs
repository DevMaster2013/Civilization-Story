using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class HumanMale : Human
    {
        public HumanMale(string n, DateTime dop, Family f)
            : base(n, true, dop, f)
        {

        }

        public override void update(double elapsedSeconds)
        {

        }         
    }
}
