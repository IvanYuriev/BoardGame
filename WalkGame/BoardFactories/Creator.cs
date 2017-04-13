using Core;

namespace WalkGame.BoardFactories
{
    class Creator
    {
        public static IBoardFactory GetBoardFactory(Levels level)
        {
            //TODO: level should not be enum!
            // If we add another level we should remember to add a lot of additional info:
            // In LevelHelper class, here add another case, refactore this to make sure
            // we ain't forget smth to add
            switch (level)
            {
                case Levels.Level0:
                    return new DefaultBoardFactory();

                case Levels.Level1:
                    return new RandomBoardFactory(LevelHelper.GetSize(level));

                case Levels.Level2:
                    return new RandomBoardFactory(LevelHelper.GetSize(level));
                
                case Levels.Level3:
                    return new CustomBoardFactory(LevelHelper.GetSize(level));
            }
            throw new CoreException("Unknown level " + level);
        }
    }
}
