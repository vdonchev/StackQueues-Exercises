namespace _04.BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class BasicQueueOperations
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var elementsCount = inputTokens[0];
            var elementsToDeque = inputTokens[1];
            var elementToFind = inputTokens[2];

            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            if (elementsToDeque > elementsCount)
            {
                queue.Clear();
            }
            else
            {
                for (int i = 0; i < elementsToDeque; i++)
                {
                    queue.Dequeue();
                }
            }

            var min = int.MaxValue;
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
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
