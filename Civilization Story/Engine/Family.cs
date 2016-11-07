using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public class Family
    {
        public Human husband = null;
        public Human wife = null;
        public List<Human> childs = new List<Human>();

        public Family(Human h, Human w)
        {
            husband = h;
            wife = w;

            husband.family = this;
            wife.family = this;

            childs = new List<Human>();
        }

        public void addChild(Human ch)
        {
            ch.family = this;
            childs.Add(ch);
        }
    }
}
