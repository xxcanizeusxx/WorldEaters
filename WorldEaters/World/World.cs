using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters
{
    class World
    {
        public readonly int Height;
        public readonly int Width;

        public World(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //Chhecks to see if a point(x, and y) are on the world.
        public bool OnWorld(WorldCoordinate coordinate)
        {
            return coordinate.X >= 0 && coordinate.X < Width &&
                   coordinate.Y >= 0 && coordinate.Y < Height;
        }
    }
}
