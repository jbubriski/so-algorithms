using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoAlgorithms
{
    public class BinarySearch
    {
        public BinarySearch()
        {

        }

        /// <summary>
        /// Searches your sorted array for a given value.
        /// </summary>
        /// <param name="values">The array of values to search through.</param>
        /// <param name="valueToSearchFor">The value to search for.</param>
        /// <returns></returns>
        public int Search(int[] values, int valueToSearchFor)
        {
            if (valueToSearchFor < values[0])
                return -1;

            if (valueToSearchFor > values[values.Length - 1])
                return -1;

            var startIndex = 0;
            var endIndex = values.Length - 1;

            while (startIndex != endIndex)
            {
                // Looking for 7

                // Second Loop:
                // start = 6
                // end = 9
                // mid = 8 (value 9)

                // Third Loop:
                // start = 6
                // end = 7
                // mid = 7 (value 8)

                // Fourth loop:
                // start = 6
                // end = 6
                // 

                var midPointIndex = startIndex + ((endIndex - startIndex) / 2); // 0-9 -> 5

                // 6 == 7?
                if (values[midPointIndex] == valueToSearchFor)
                {
                    return midPointIndex;
                }
                else if (values[midPointIndex] < valueToSearchFor)
                {
                    // 6
                    startIndex = midPointIndex + 1;
                }
                else
                {
                    // 8
                    endIndex = midPointIndex - 1;
                }
            }

            if (values[startIndex] == valueToSearchFor)
            {
                return startIndex;
            }

            return -1;
        }
    }
}
