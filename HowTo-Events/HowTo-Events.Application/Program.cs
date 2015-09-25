using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo_Events.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Video myVideo = new Video();
            myVideo.Title = "Video 1";

            VideoEncoder myVideoEncoder = new VideoEncoder();       // Publisher
            MailService myMailService = new MailService();          // Subscriber
            MessageService myMessageService = new MessageService(); // Another subscriber

            myVideoEncoder.VideoEncoded += myMessageService.OnVideoEncoded;
            myVideoEncoder.VideoEncoded += myMailService.OnVideoEncoded; /* Code explanation:
                                                                         * the object "myVideoEncoder" has an event called "VideoEncoded", 
                                                                         * we then add the "OnVideoEncoded" method from "myMailService" as a subscriber, 
                                                                         * so that when "myVideoEncoder" raises the event "VideoEncoded", the 
                                                                         * function: "OnVideoEncoded" is called from the class: "myMailService".
                                                                         */

            myVideoEncoder.Encode(myVideo);

        }
    }
}
