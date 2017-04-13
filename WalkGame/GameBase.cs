using System.Text;
using Core;
using WalkGame.BoardFactories;

namespace WalkGame
{
    public abstract class GameBase
    {
        private readonly Levels _level;
        private readonly int _size;

        protected GameBase(Levels level)
        {
            _level = level;
            _size = LevelHelper.GetSize(_level);
            CreateBoard();
        }

        protected void CreateBoard()
        {
            Board = new Board(_size);
            Board.Construct(Creator.GetBoardFactory(_level));
        }
        
        public Board Board { get; private set; } 

        public string PrintBoard()
        {
            //TODO: single responsibility is violated, needs to extract
            // the displaying logic in different class
            var sb = new StringBuilder();
            var tiles = Board.GetAll();
            for (var i = 0; i < Board.Size; i++)
            {
                for (var j = 0; j < Board.Size; j++)
                {
                    sb.AppendFormat(" {0} ", new TileView(tiles[i, j]));
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
