namespace _08.RecursiveFibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public static class RecursiveFibonacci
    {
        private static Dictionary<int, BigInteger> memo = 
            new Dictionary<int, BigInteger>(); 

        public static void Main()
        {
            var nth = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcFib(nth));

        }

        private static BigInteger CalcFib(int nth)
        {
            if (nth == 1 || nth == 2)
            {
                return 1;
            }

            if (!memo.ContainsKey(nth))
            {
                memo[nth] = CalcFib(nth - 1) + CalcFib(nth - 2);
            }

            return memo[nth];
        }
    }
}
