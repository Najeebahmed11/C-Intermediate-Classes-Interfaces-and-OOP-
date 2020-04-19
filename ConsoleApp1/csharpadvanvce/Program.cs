using System.Runtime.InteropServices;

namespace csharpadvanvce
{
    class Program
    {
          
        static void Main(string[] args)
        {
            //events and delegates:
            //event:a mechinism of communication between two objects
            //it help in building loosly couple apps
            //delegent is agreement between publisher and subscriber
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();//subscriber
            var messageService = new MessageService();//subscriber

            videoEncoder.videoEncoded += mailService.OnVideoEncoded;//this is reference to that method
            //video encoded events is list of methods
            videoEncoder.videoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
