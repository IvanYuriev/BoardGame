using System;
using Core;

namespace WalkGame
{
    public class Board
    {
        private readonly Tile[,] _board;
        
        public Board(int size)
        {
            Size = size;
            _board = new Tile[size, size];
            for (var i = 0; i < Size; i++)
                for (var j = 0; j < Size; j++)
                    _board[i, j] = Tile.EmptyTile;
        }

        public int Size { get; }

        public Tile GetTileAt(int x, int y)
        {
            if (x > Size || x < 0)
                throw new ArgumentOutOfRangeException(nameof(x));

            if (y > Size || y < 0)
                throw new ArgumentOutOfRangeException(nameof(y));

            return _board[x, y];
        }

        public Tile[,] GetAll()
        {
            return _board;
        }

        public void Construct(IBoardFactory factory)
        {
            for (var x = 0; x < Size; x++)
                for (var y = 0; y < Size; y++)
                    _board[x, y] = new Tile(factory.GetTileForPosition(x, y));
        }
    }
}
