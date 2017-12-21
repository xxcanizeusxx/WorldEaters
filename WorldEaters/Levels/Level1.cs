using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEaters.Defenders;
using WorldEaters.Eaters;

namespace WorldEaters.Levels
{
    class Level1
    {
        private readonly IEater[] _eaters;

        public Level1(IEater[] eaters)
        {
            _eaters = eaters;
        }

        public Defender[] Defenders{ get; set; }

        public bool Play()
        {
            //Will run until all invaders are neutralized or invader reaches end of path
            //Each tower has the ability to shoot
            int remainingEaters = _eaters.Length;

            while (remainingEaters > 0)
            {
                foreach (Defender defender in Defenders)
                {
                    defender.FireOnEaters(_eaters);
                }
                //Count and move the invaders that are still active
                remainingEaters = 0;
                foreach (IEater eater in _eaters)
                {
                    if (eater.IsActive)
                    {
                        eater.Move();
                        if (eater.HasHit)
                        {
                            return false;
                        }

                        remainingEaters++;
                    }
                }
            }
            return true;
        }
    }
}
