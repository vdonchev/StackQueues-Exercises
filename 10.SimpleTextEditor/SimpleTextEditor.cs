namespace _10.SimpleTextEditor
{
    using System;
    using System.Collections.Generic;

    public static class SimpleTextEditor
    {
        private static string text = string.Empty;
        private static readonly Stack<string> History =
            new Stack<string>();

        public static void Main()
        {
            var numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                var inputTokens = Console.ReadLine().Split();
                switch (inputTokens[0])
                {
                    case "1":
                        var textToAppend = inputTokens[1];
                        History.Push(text);
                        text += textToAppend;
                        break;
                    case "2":
                        var countToRemove = int.Parse(inputTokens[1]);
                        History.Push(text);
                        text = text.Substring(0, text.Length - countToRemove);
                        break;
                    case "3":
                        var indexToShow = int.Parse(inputTokens[1]);
                        Console.WriteLine(text[indexToShow - 1]);
                        break;
                    case "4":
                        if (History.Count > 0)
                        {
                            text = History.Pop();
                        }
                        break;
                }
            }
        }
    }
}