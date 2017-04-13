using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;

namespace WalkGame
{
    public class Board
    {
        private Tile[,] _board;
        
        public Board(int size)
        {
            Size = size;
            _board = new Tile[size, size];
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    _board[i, j] = Tile.EmptyTile;
        }

        public int Size { get; private set; }

        public Tile GetTileAt(int x, int y)
        {
            if (x > Size || x < 0) throw new ArgumentOutOfRangeException("x");
            if (y > Size || y < 0) throw new ArgumentOutOfRangeException("y");

            return _board[x, y];
        }

        public Tile[,] GetAll()
        {
            return _board;
        }

        public void Construct(IBoardFactory factory)
        {
            for (int x = 0; x < Size; x++)
                for (int y = 0; y < Size; y++)
                    _board[x, y] = new Tile(factory.GetTileForPosition(x, y));
        }
    }
}
