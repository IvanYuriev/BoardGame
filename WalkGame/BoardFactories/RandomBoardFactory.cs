using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;

namespace WalkGame.BoardFactories
{
    class RandomBoardFactory : IBoardFactory
    {
        private IList<TileTypes> _map;
        private int _size;
        private static Random rng = new Random();

        public RandomBoardFactory(int size)
        {
            _size = size;
            _map = new List<TileTypes>();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    _map.Add(rng.Next(100) % 5 == 0 ?
                        TileTypes.Wall :
                        TileTypes.Empty);
                }
            }
            Shuffle(_map);
            _map[0] = TileTypes.Start;
            _map[_map.Count - 1] = TileTypes.End;
        }

        public TileTypes GetTileForPosition(int x, int y)
        {
            return _map[x + y * _size];
        }

        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
