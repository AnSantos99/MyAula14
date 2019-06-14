using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleStuff
{
    internal class SuperList : List<double>
    {

        public struct MinMax
        {
            // --------------Properties

            // Get min value
            public double Min { get; }

            // Get max value
            public double Max { get; }

            // Constructors
            public MinMax(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        /// <summary>
        /// Get in and max value of list
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void GetMinMax(out double min, out double max)
        {
            // Sort list
            Sort();

            // Get first element of list
            min = this[0];

            // Get last  element of list
            max = this[Count -1];
        }

        /// <summary>
        /// Get Multiple values with struct
        /// </summary>
        /// <param name="s"></param>
        public MinMax GetMinMax()
        {
            // Declare variable
            double min, max;

            // Get minmax that return min and max value
            GetMinMax(out min, out max);

            // New instance of struct
            return new MinMax(min, max);
        }

        /// <summary>
        /// Save multiples values and print them out
        /// </summary>
        /// <returns> Min and Max value</returns>
        public Tuple<double, double> GetMinMax2()
        {
            double min, max;
            GetMinMax(out min, out max);

            return new Tuple<double, double>(min, max);
        }

       
    }
}
