namespace csharpintermediate
{

    public class Program
    {
        static void Main(string[] args)
        {
            //completed summary
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());


        }

    }       
}

