using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkGame
{
    public class TileView
    {
        private Tile _tile;

        public TileView(Tile tile)
        {
            _tile = tile;
        }

        public override string ToString()
        {
            switch(_tile.Type)
            {
                case Core.TileTypes.Empty:  return "0";
                case Core.TileTypes.Start:  return "s";
                case Core.TileTypes.End:    return "X";
                case Core.TileTypes.Wall:   return "|";
            }
            return "#";
        }
    }
}
