using System;

namespace csharpadvanvce
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
            //this base is exception class
        {
        }
    }
}