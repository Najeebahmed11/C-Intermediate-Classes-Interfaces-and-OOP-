using System;

namespace csharpintermediate
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string messages)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(messages);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}

