using SoAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoAlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var values = new int[1] { 1 };
            //var values = new int[2] { 1, 2 };
            //var values = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var values = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var binarySearch = new BinarySearch();

            var value = 1;
            var expectedResult = 0;
            var result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 2;
            expectedResult = 1;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 3;
            expectedResult = 2;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 4;
            expectedResult = 3;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 5;
            expectedResult = 4;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 6;
            expectedResult = 5;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 7;
            expectedResult = 6;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 8;
            expectedResult = 7;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 9;
            expectedResult = 8;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 10;
            expectedResult = 9;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 0;
            expectedResult = -1;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 11;
            expectedResult = -1;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);



            values = new int[] { 1, 2, 3, 4, 5 };

            value = 0;
            expectedResult = -1;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 10;
            expectedResult = -1;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 1;
            expectedResult = 0;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 2;
            expectedResult = 1;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 3;
            expectedResult = 2;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 4;
            expectedResult = 3;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            value = 5;
            expectedResult = 4;
            result = binarySearch.Search(values, value);
            OutputResult(expectedResult, result, value);

            Console.ReadKey();
        }

        public static void OutputResult(int expectedResult, int result, int value)
        {
            if (result == expectedResult)
            {
                Console.WriteLine($"Success: Value {value} found at index {result}");
            }
            else
            {
                Console.WriteLine($@"
**********************************************
Failure: Value {value} found at index {result}, expected {expectedResult}
**********************************************");
            }
        }
    }
}
