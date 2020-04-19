
using System;

namespace csharpadvanvce
{
    public class MailService
    {
        public void OnVideoEncoded(object source,VideoEventArgs e)
        {
            Console.WriteLine("we are in mail service sending an email" + e.Video.Title);

        }
    }
}
