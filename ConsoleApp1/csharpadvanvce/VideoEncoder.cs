using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharpadvanvce
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }
    public class VideoEncoder
    {
        //1 define a delegate:agreement between a publisher and subscriber
        //2 define an event
        //3 raise the event
       // public delegate void videoEncodedEventHandler(object source, VideoEventArgs args);
        public event EventHandler<VideoEventArgs> videoEncoded;
        public event EventHandler videoEncodeing;
        public void Encode(Video video)
        {
            Console.WriteLine("encoding video.....");
            Thread.Sleep(3000);
            onVideoEncoded(video);
        }
        //event should be protected,virtual and void
        protected virtual void onVideoEncoded(Video video)
        {
            if (videoEncoded != null)
            {
                videoEncoded(this, new VideoEventArgs() { Video=video});
            }
        }
    }
}
