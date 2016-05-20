namespace _02.ReverseNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class BasicStackOperations
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var elementsCount = inputTokens[0];
            var elementsToPop = inputTokens[1];
            var elementToFind = inputTokens[2];

            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            if (elementsToPop > elementsCount)
            {
                stack.Clear();
            }
            else
            {
                for (int i = 0; i < elementsToPop; i++)
                {
                    stack.Pop();
                }
            }

            var min = int.MaxValue;
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (current == elementToFind)
                {
                    Console.WriteLine("true");
                    return;
                }

                min = Math.Min(min, current);
            }

            Console.WriteLine(min);
        }
    }
}
