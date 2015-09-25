using System;

namespace HowTo_Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending message..." + e.Video.Title);
        }
    }
}