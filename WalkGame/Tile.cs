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
            Type = type;
        }

        public TileTypes Type { get; private set; }
    }
}
