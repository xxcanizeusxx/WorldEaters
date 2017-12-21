using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Utils
{
    /* This class is an example of a static class which
       defines a static global method.
    */
    static class Random
    {
        private static System.Random _random = new System.Random();

        public static double NextDouble()
        {
            return _random.NextDouble();
        }
    }
}
