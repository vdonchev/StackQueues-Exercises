namespace _06.TruckTour
{
    using System;
    using System.Linq;

    public static class TruckTour
    {
        public static void Main()
        {

            int fuel = 0;
            int pumpIndex = 0;
            var pumpCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < pumpCount; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int petrol = input[0];
                int distance = input[1];

                fuel += petrol - distance;

                if (fuel < 0)
                {
                    fuel = 0;
                    pumpIndex = i + 1;
                }
            }

            Console.WriteLine(pumpIndex);
        }
    }
}
