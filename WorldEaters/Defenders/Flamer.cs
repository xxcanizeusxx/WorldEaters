using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEaters.Utils;

namespace WorldEaters.Defenders
{
    class Flamer : Defender
    {
        public Flamer(WorldLocation location, Path path, Score score) : base(location, path, score)
        { }
        protected override int Range { get; } = 1;
        protected override double Accuracy { get; } = 0.5;
        protected override int Power { get; } = 2;
    }
}
