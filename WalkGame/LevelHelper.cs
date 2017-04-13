using System;
using Core;

namespace WalkGame
{
    class LevelHelper
    {
        public static int GetSize(Levels level)
        {
            switch(level)
            {
                case Levels.Level0:
                case Levels.Level1:
                case Levels.Level3:
                    return 5;

                case Levels.Level2:
                    return 10;

                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }
    }
}
