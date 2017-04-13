using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;

namespace WalkGame
{
    class LevelHelper
    {
        public static int GetSize(Levels level)
        {
            switch(level)
            {
                case Levels.Level0: return 5;
                case Levels.Level1: return 5;
                case Levels.Level2: return 10;
            }
            return 0;
        }
    }
}
