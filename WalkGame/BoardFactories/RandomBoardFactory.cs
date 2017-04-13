using System;
using System.Collections.Generic;
using Core;

namespace WalkGame.BoardFactories
{
    class RandomBoardFactory : BaseBoard
    {
        private static readonly Random rng = new Random();

        public RandomBoardFactory(int size)
        {
            Size = size;
            var map = new List<TileTypes>();
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    map.Add(rng.Next(100) % 5 == 0 ?
                        TileTypes.Wall :
                        TileTypes.Empty);
                }
            }

            Map = Shuffle(map);
            SetPointers();
        }

        private static IList<T> Shuffle<T>(IList<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }
}
