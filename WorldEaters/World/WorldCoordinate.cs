using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEaters.Utils;

namespace WorldEaters
{
    class WorldCoordinate
    {
        public readonly int X;
        public readonly int Y;

        public WorldCoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public override string ToString()
        {
            return X + ", " + Y;
        }

        //Overrides the Equals method to check if two locations are the same
        public override bool Equals(object obj)
        {
            if (!(obj is WorldCoordinate))
            {
                return false;
            }

            WorldCoordinate compare = obj as WorldCoordinate;
            return this.X == compare.X && this.Y == compare.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }

        //Checks the distance from x and y 
        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        //Overload of DistanceTo Checks the distance point object x and point object y
        public int DistanceTo(WorldCoordinate coordinate)
        {
            return DistanceTo(coordinate.X, coordinate.Y);
        }
    }

    class WorldLocation : WorldCoordinate
    {
        public WorldLocation(int x, int y, World world) : base(x, y)
        {
            //Cheks if the path is not otside the map boundries
            if (!world.OnWorld(this))
            {
                throw new OutOfBoundsException(this + " is outside map boundries!");
            }
        }
        //Checks to see if the location is within range
        public bool InRangeOf(WorldLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
