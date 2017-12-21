using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Eaters
{
    class ArmoredEater : Eater
    {
        public ArmoredEater(Path path) : base(path)
        { }
        public override int Health { get; protected set; } = 4;
        //Overrides the base class virtual method DecreaseHealth
        public override void DecreaseHealth(int amnt)
        {
            if (Utils.Random.NextDouble() < .5)
            {
                base.DecreaseHealth(amnt);
            }
            else
            {
                Console.WriteLine("Deflected by Armored Eater");
            }
        }
    }
}
