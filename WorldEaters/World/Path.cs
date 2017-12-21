using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters
{
    class Path
    {
        private readonly WorldLocation[] _path;

        public Path(WorldLocation[] path)
        {
            _path = path;
        }

        //Returns the Length of the path
        public int Length => _path.Length;

        //Gets the location of the path in the Map returns null if not found
        public WorldLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        //Checks to see if a component such as the tower is on the path
        public bool OnPath(WorldLocation location)
        {
            foreach (var pathLocation in _path)
            {
                if (location.Equals(pathLocation))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
