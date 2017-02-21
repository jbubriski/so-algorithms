using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // var name = "Chiemeka";
            var valueToSearchFor = 3;
            var values = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var searcher = new BinarySearch();

            var index = searcher.Search(values, valueToSearchFor);

            if (index >= 0)
            {
                Console.WriteLine("Value found at index " + index);
            }
            else
            {
                Console.WriteLine("Value not found");
            }

            Console.ReadKey();


            Console.WriteLine("Input a number and press enter");

            while (true)
            {
                var stringInput = Console.ReadLine();
                var number = 0;

                if (int.TryParse(stringInput, out number))
                {
                    // your code here

                }
                else
                {
                    Console.WriteLine("Invalid number, please try again");
                }
            }
        }
    }
}
