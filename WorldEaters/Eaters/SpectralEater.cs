using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Eaters
{
    /* This class is an example of composition which creates a new type of 
      Eater that behaves like an Eater but does not directly inherit
      from the Eater base class. This new type of Eater starts off as a 
      basic eater, when kiled, it transforms into a buff eater(strong eater).
   */
    class SpectralEater : IEater
    {
        private BasicEater _grave1;
        private BuffEater _grave2;

        public SpectralEater(Path path)
        {
            _grave1 = new BasicEater(path);
            _grave2 = new BuffEater(path);
        }
        public WorldLocation Location => _grave1.IsDead ? _grave2.Location : _grave1.Location;
        public int Health => _grave1.IsDead ? _grave2.Health : _grave1.Health;
        public bool HasHit => _grave1.HasHit || _grave2.HasHit;
        public bool IsDead => _grave1.IsDead || _grave2.IsDead;
        public bool IsActive => !(IsDead || HasHit);
        public void Move()
        {
            _grave1.Move();
            _grave2.Move();
        }
        public void DecreaseHealth(int amnt)
        {
            if (!_grave1.IsDead)
            {
                _grave1.DecreaseHealth(amnt);
            }
            else
            {
                _grave2.DecreaseHealth(amnt);
            }
        }
    }
}
