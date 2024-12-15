using System;
using System.Diagnostics;

namespace BracketValidatorApp
{
    /// <summary>
    /// The entry point for the BracketValidatorApp application.
    /// This program prompts the user to input a string and checks if the string contains matching brackets.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method of the application.
        /// It prompts the user to enter a string and validates whether the brackets in the string are matched correctly.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Enter a string to check for matching brackets:");

            // Handle null or empty input scenario
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a string.");
            }
            else
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                bool result = BracketMatcher.HasMatchingBrackets(input);

                stopwatch.Stop();

                Console.WriteLine("Time taken to check brackets: {0} ms", stopwatch.ElapsedMilliseconds);

                Console.WriteLine(result ? "👍 Brackets are correctly matched." : "👎 Brackets are mismatched.");
            }
        }
    }
}
