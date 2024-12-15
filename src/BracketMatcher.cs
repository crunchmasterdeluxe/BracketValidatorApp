using System;
using System.Collections.Generic;

namespace BracketValidatorApp
{
    /// <summary>
    /// Provides functionality to check if a string has matching pairs of brackets.
    /// Supports multiple types of brackets: (), {}, [], and <>.
    /// </summary>
    public class BracketMatcher
    {
        /// <summary>
        /// Checks if the input string contains matching pairs of brackets.
        /// Brackets are considered matched if each opening bracket has a corresponding
        /// closing bracket in the correct order.
        /// </summary>
        /// <param name="input">The input string containing brackets to be validated.</param>
        /// <returns>
        /// <c>true</c> if the brackets in the input string are correctly matched; 
        /// otherwise, <c>false</c>.
        /// </returns>
        public static bool HasMatchingBrackets(string input)
        {
            // Stack to store opening brackets
            Stack<char> stack = new Stack<char>();

            // Dictionary to store bracket pairs for quick lookup
            var bracketPairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
                { '<', '>' }
            };

            foreach (char c in input)
            {
                // If it's an opening bracket, push it onto the stack
                if (bracketPairs.ContainsKey(c))
                {
                    stack.Push(c);
                }
                // If it's a closing bracket, check if it matches the top of the stack
                else if (bracketPairs.ContainsValue(c))
                {
                    if (stack.Count == 0 || bracketPairs[stack.Pop()] != c)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0; // Stack should be empty if all brackets are matched
        }
    }
}
