using System.Collections.Generic;
using Core;

namespace WalkGame.BoardFactories
{
    public abstract class BaseBoard : IBoardFactory
    {
        public int Size { get; set; }
        public IList<TileTypes> Map { get; set; }

        public TileTypes GetTileForPosition(int x, int y)
        {
            return Map[Size * y + x];
        }

        public void SetPointers()
        {
            Map[0] = TileTypes.Start;
            Map[Map.Count - 1] = TileTypes.End;
        }
    }
}