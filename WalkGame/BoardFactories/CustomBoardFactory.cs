using System.Collections.Generic;
using Core;

namespace WalkGame.BoardFactories
{
    public class CustomBoardFactory : BaseBoard
    {
        public CustomBoardFactory(int size)
        {
            Size = size;

            var map = new List<TileTypes>();
            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                    map.Add(j != size - 1 ? TileTypes.Empty : TileTypes.Wall);

            Map = map;
            SetPointers();
        }
    }
}