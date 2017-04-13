using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;

namespace WalkGame
{
    /// <summary>
    /// Immutable representation of board cell
    /// </summary>
    public struct Tile
    {
        public static Tile EmptyTile = new Tile(TileTypes.Empty);

        public Tile(TileTypes type)
        {
            this.Type = type;
        }

        public TileTypes Type { get; private set; }
    }
}
