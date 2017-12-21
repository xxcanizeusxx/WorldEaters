using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEaters.Utils;

namespace WorldEaters.Defenders
{
    class Sniper : Defender
    {
        public Sniper(WorldLocation location, Path path, Score score) : base(location, path, score)
        { }
        protected override int Range { get; } = 3;
        protected override double Accuracy { get; } = 1.0;
        protected override int Power { get; } = 3;
    }
}
