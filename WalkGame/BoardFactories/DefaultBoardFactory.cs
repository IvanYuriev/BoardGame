using Core;

namespace WalkGame.BoardFactories
{
    class DefaultBoardFactory : IBoardFactory
    {
        public TileTypes GetTileForPosition(int x, int y)
        {
            return TileTypes.Empty;
        }
    }
}
