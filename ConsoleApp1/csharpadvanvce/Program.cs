using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpadvanvce
{
    class Program
    {
        public static void Main(string[] args)
        {
            //exception is a class
            //stack_trace:the sequence of methods that were called untill exception was thrown
            //in exception handling source represent dll or assembly
            //we should put exception from most specific to most generic
            //in this way we can handle exceptions
            //Idosposible use desposible to manage resources
            //dispose()is usually use to close file
            //databases,network connection,graphics,make sure to use dispose
            //using block have its own dispose() insted of calling finally block
            //entity framewok usualyy have inner exceptions

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
