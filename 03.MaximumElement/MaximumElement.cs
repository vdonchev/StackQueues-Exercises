namespace _03.MaximumElement
{
    using System;
    using System.Collections.Generic;

    public static class MaximumElement
    {
        public static void Main()
        {
            var elements = new Stack<int>();
            var maximums = new Stack<int>();
            maximums.Push(-1);

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var command = Console.ReadLine();
                if (command[0] == '1')
                {
                    var element = int.Parse(command.Substring(2));

                    if (element > maximums.Peek())
                    {
                        maximums.Push(element);
                    }

                    elements.Push(element);
                }
                else if (command[0] == '2')
                {
                    var element = elements.Pop();
                    if (element == maximums.Peek())
                    {
                        maximums.Pop();
                    }
                }
                else
                {
                    Console.WriteLine(maximums.Peek());
                }
            }
        }
    }
}