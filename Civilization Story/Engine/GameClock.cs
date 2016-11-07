using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization_Story.Engine
{
    public static class GameClock
    {
        public static DateTime currentTime = GameSettings.gameStartDate;

        public static void update(double elapsedSeconds)
        {
            currentTime += TimeSpan.FromSeconds(elapsedSeconds * GameSettings.gameSpeedFactor);
        }
    }
}
