using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Eaters
{
    class BuffEater : Eater
    {
        public BuffEater(Path path) : base(path)
        { }

        public override int Health { get; protected set; } = 5;
    }
}
