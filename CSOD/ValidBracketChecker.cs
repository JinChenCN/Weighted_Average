using System;
using System.Collections.Generic;
using System.Linq;

namespace CSOD
{
    public class ValidBracketChecker
    {
        public bool ContainsValidBrackets(string sourceCode)
        {
            if (sourceCode == null)
            {
                throw new Exception("Input is null!");
            }

            var stack = new Stack<char>();
            var brackets = new Dictionary<char, char>
            {
                {']', '['},
                {'}', '{'},
                {')', '('},
                {'>', '<'}
            };

            var leftBracketsTotal = 0;
            var rightBracketsTotal = 0;
            foreach (KeyValuePair<char, char> kv in brackets)
            {
                leftBracketsTotal = sourceCode.Count(c => c == kv.Value);
                rightBracketsTotal = sourceCode.Count(c => c == kv.Key);

                if (leftBracketsTotal != rightBracketsTotal)
                {
                    return false;
                }
            }

            foreach (char c in sourceCode.ToCharArray())
            {
                if (!brackets.Keys.Contains(c) && !brackets.Values.Contains(c))
                {
                    continue;
                }

                if (brackets.Values.Contains(c))
                {
                    stack.Push(c);
                }
                else
                {
                    var storedValue = stack.Pop();
                    var leftBracket = brackets[c];
                    if (storedValue.Equals(leftBracket))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

            }

            return true;

        }
    }
}
