using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Utilities
{
    public static class GameSettings
    {
        public static double gameSpeedFactor = 1.0 * 60 * 60 * 24 * 30 * 12;
        public static DateTime gameStartDate = new DateTime(21, 1, 1, 0, 0, 0);
    }
}
