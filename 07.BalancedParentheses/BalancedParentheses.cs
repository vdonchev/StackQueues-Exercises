namespace _07.BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class BalancedParentheses
    {
        private static readonly char[] Opening = { '{', '[', '(' };

        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            var a = stack.Peek();

            foreach (var parentheses in input)
            {
                if (Opening.Contains(parentheses))
                {
                    stack.Push(parentheses);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    var current = stack.Peek();
                    if (parentheses == '}' && current != '{' ||
                        parentheses == ']' && current != '[' ||
                        parentheses == ')' && current != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    stack.Pop();
                }
            }

            Console.WriteLine("YES");
        }
    }
}
