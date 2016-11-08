using Engine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Modules.Humans
{
    public class Pregnant
    {
        public delegate void pregnantCompleteHandler(Pregnant pregnant, bool succeeded);

        public DateTime startDate;
        public DateTime endDate;
        public TimeSpan duration;
        public bool isSave;
        public bool isMale;
        public HumanFemale mother;
        public event pregnantCompleteHandler onPregnantComplete;
        public bool isDone = false;

        public Pregnant(HumanFemale m)
        {
            mother = m;
            startDate = GameClock.currentTime;
            isMale = RandomGenerator.getRandomNumber(0, 1) > 0.5;
            duration = getRandomPregnantDuration();
        }

        public void update(double elapsedSeconds)
        {
            if (GameClock.currentTime - startDate >= duration)
            {
                isDone = true;
                endDate = GameClock.currentTime;
                if (onPregnantComplete != null)
                    onPregnantComplete(this, isSave);
            }
        }

        private TimeSpan getRandomPregnantDuration()
        {
            TimeSpan saveTime = RandomGenerator.getRandomTimeSpan(TimeSpan.FromDays(7 * 30), TimeSpan.FromDays(9 * 30));
            TimeSpan failTime = RandomGenerator.getRandomTimeSpan(TimeSpan.FromDays(0 * 30), TimeSpan.FromDays(7 * 29));
            double propabilityToSuccess = RandomGenerator.getRandomNumber(0, 1);
            isSave = propabilityToSuccess < mother.faction.humanManagement.savePregnantPropability;
            return isSave ? saveTime : failTime;
        }
    }
}
