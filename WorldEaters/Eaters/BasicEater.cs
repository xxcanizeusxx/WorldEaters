using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Eaters
{
    class BasicEater : Eater
    {
        public BasicEater(Path path) : base(path)
        { }

        public override int Health { get; protected set; } = 2;
        protected override int StepSize { get; } = 2;
    }
}
