namespace _01.ReverseNumbersWithaStack
{
    using System;
    using System.Collections.Generic;

    public static class ReverseNumbersWithaStack
    {
        public static void Main()
        {
            var stack = new Stack<string>(Console.ReadLine().Split());
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
