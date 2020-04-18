using System.IO;

namespace csharpintermediate
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }
        public void LogError(string messages)
        {
            Log(messages, "error");
            
        }

        public void LogInfo(string message)
        {
            Log(message, "info");
        }
        private void Log(string message, string messagetype)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messagetype + ":"+ message);

            }

        }
    }
}

