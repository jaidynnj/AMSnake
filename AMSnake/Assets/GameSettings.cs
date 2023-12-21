using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSnake.Assets
{
    public static class GameSettings
    {
        public static int ShakeDuration { get; set; } = 2000;
        public static int boostSpeed { get; set; } = 100;
        public static double WallDensity { get; set; } = .15;
        public static bool WallFatality { get; set; } = true;
    }
}
