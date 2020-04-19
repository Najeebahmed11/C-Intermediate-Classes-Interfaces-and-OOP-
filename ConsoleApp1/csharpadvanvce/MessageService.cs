
using System;

namespace csharpadvanvce
{
    public class MessageService
    {
        public void OnVideoEncoded(object source,VideoEventArgs args)
        {
            Console.WriteLine("Message service:sending an text" + args.Video.Title);

        }
    }
}
