using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEaters.Eaters;
using WorldEaters.Utils;

namespace WorldEaters.Defenders
{
    class Defender
    {
        private readonly WorldLocation _location;
        private Path _path;
        private readonly Score _score;

        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        public Defender(WorldLocation location, Path path, Score score)
        {
            _location = location;
            _path = path;
            _score = score;

            //Checks to see if the Tower is placed on the Path
            if (_path.OnPath(location))
            {
                throw new OnPathException("You cannot place the Defender in the path!");
            }
        }

        //Shot calculation 
        public bool IsShotSuccessful()
        {
            return Utils.Random.NextDouble() < Accuracy;
        }

        //Fires on Eater if its within range
        public void FireOnEaters(IEater[] eaters)
        {
            foreach (IEater eater in eaters)
            {
                if (eater.IsActive && _location.InRangeOf(eater.Location, Range))
                {
                    if (IsShotSuccessful())
                    {
                       eater.DecreaseHealth(Power);

                        if (eater.IsDead)
                        {
                            _score.setInvadersKilled(1);
                            Console.WriteLine("Killed an eater at: " + eater.Location + "! " + "Kills: " +
                                _score.InvadersKilled);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot missed at: " + eater.Location);
                    }

                    _score.IncreaseScore(10);
                    break;
                }
            }
        }
    }
}
