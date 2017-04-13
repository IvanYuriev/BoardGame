using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public interface IBoardFactory
    {
        TileTypes GetTileForPosition(int x, int y);
    }
}
