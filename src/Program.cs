using System;

namespace BracketValidatorApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string to check for matching brackets:");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a string.");
            }
            else
            {
                bool result = BracketMatcher.HasMatchingBrackets(input);
                Console.WriteLine(result ? "Brackets are correctly matched!" : "Brackets are mismatched.");
            }
        }
    }
}
