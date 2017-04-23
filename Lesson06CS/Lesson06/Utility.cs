using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson06
{
    class Utility
    {

        public static double CalculateGasPrices(int miles)
        {
            // Could based this on make and model
            // using a switch statement, but hopefully
            // you get the idea of when a static method
            // could be helpful when creating classes
            // filled with utilities.

            return miles * .35;

        }

    }
}
