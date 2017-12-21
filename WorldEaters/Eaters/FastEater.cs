using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Eaters
{
    class FastEater : Eater
    {
        public FastEater(Path path) : base(path)
        { }

        protected override int StepSize { get; } = 2;
        public override int Health { get; protected set; } = 2;

    }
}
