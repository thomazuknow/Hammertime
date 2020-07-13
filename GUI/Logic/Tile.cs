using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Hammertime.GUI.Logic
{
    public class Tile
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public TileType TileType { get; private set; }
        public TileDirection TileDirection { get; private set; }

        public int x { get; set; }
        public int y { get; set; }


        public void ChangeType(TileType tileType)
        {
            this.TileType = tileType;
        }

        public void SetDirection(TileDirection directions)
        {
            this.TileDirection = directions;
        }

    }

    [Flags]
    public enum TileDirection
    {
        None = 0,
        North = 1,
        South = 2,
        West = 4,
        East = 8,


    }

    public enum TileType
    {
        Front = 0,
        Flipped = 1

    }
}
