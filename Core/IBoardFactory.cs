namespace Core
{
    public interface IBoardFactory
    {
        TileTypes GetTileForPosition(int x, int y);
    }
}
