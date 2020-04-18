namespace csharpintermediate
{

    public class Program
    {
        static void Main(string[] args)
        {
            //interfaces are not for multiple inheritance
            //a class can have multiplle base classes
            //but csharp is not applicable however we can impliment 
            //multiple interfaces
            // a class only impliment ierfaces
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());


        }

    }       
}

