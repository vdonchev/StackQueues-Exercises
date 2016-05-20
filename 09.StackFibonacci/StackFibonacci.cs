namespace _09.StackFibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public static class StackFibonacci
    {
        public static void Main()
        {
            var fibToLookFor = int.Parse(Console.ReadLine());
            var fib = new Stack<BigInteger>();
            fib.Push(1);
            fib.Push(1);

            var nthFib = 2;
            while (nthFib < fibToLookFor)
            {
                var b = fib.Pop();
                var a = fib.Peek();
                fib.Push(b);
                fib.Push(a + b);
                nthFib++;
            }

            Console.WriteLine(fib.Peek());
        }
    }
}
