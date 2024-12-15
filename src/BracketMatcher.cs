using System;
using System.Collections.Generic;

namespace BracketValidatorApp
{
    public class BracketMatcher
    {
        public static bool HasMatchingBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();
            var bracketPairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' },
                { '<', '>' }
            };

            foreach (char c in input)
            {
                if (bracketPairs.ContainsKey(c)) // Opening bracket
                {
                    stack.Push(c);
                }
                else if (bracketPairs.ContainsValue(c)) // Closing bracket
                {
                    if (stack.Count == 0 || bracketPairs[stack.Pop()] != c)
                    {
                        return false; // Mismatched or unbalanced
                    }
                }
            }

            return stack.Count == 0; // Stack should be empty if all brackets are matched
        }
    }
}
