using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using WalkGame.BoardFactories;

namespace WalkGame
{
    public abstract class GameBase
    {
        private Levels _level;
        private int _size;

        public GameBase(Levels level)
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
            for (int i = 0; i < Board.Size; i++)
            {
                for (int j = 0; j < Board.Size; j++)
                {
                    sb.AppendFormat(" {0} ", new TileView(tiles[i, j]));
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
