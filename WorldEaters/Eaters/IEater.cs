using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Eaters
{
    /* Interface of the Eater component that define what public members a class 
      should have along with properties, methods and their return types. Interfaces
      only expose what is absolutely needed by the code that is using the class.
   */
    interface IEater
    {
        int Health { get; }
        bool HasHit { get; }
        bool IsDead { get; }
        bool IsActive { get; }
        void DecreaseHealth(int amnt);
        WorldLocation Location { get; }
        void Move();
    }
}
