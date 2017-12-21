using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorldEaters.Eaters
{
    /* The Eater class is responsible for creating a blueprint of Invaders. This class
      implements the IEater interface and is composed of various properties and methods
      which define an Eater.
   */
    abstract class Eater : IEater
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public Eater(Path path)
        {
            _path = path;
        }

        //Methods and Properties of the Eater class/component
        protected virtual int StepSize { get; } = 1;
        public WorldLocation Location => _path.GetLocationAt(_pathStep);
        public abstract int Health { get; protected set; }
        public bool HasHit { get { return _pathStep >= _path.Length; } }
        public bool IsDead => Health <= 0;
        public bool IsActive => !(IsDead || HasHit);
        public void Move() => _pathStep += StepSize;

        //Decreases the Eaters health
        public virtual void DecreaseHealth(int amnt)
        {
            Health -= amnt;
            Console.WriteLine("Shot at and hit an Eater!");
        }
    }
}
