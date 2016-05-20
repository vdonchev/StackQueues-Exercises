namespace _05.CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public static class CalculateSequenceWithQueue
    {
        public static void Main()
        {
            var queue = new Queue<BigInteger>();
            queue.Enqueue(BigInteger.Parse(Console.ReadLine()));
            var steps = 0;
            while (queue.Count > 0 && steps++ < 50)
            {
                var num = queue.Dequeue();
                Console.Write($"{num} ");
                queue.Enqueue(num + 1);
                queue.Enqueue((2 * num) + 1);
                queue.Enqueue(num + 2);
            }

            Console.WriteLine();
        }
    }
}
