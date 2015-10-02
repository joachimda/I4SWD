using System;
using System.Threading;

namespace HowTo_Events.Minimal
{
    class Program
    {
        public class MailService
        {
            public void OnEncodingDone()
            {
                Console.WriteLine(GetType().Name + " heard the event.");
            }
        }
        public class Video
        {
            public string Title { get; set; }

            public Video(string title)
            {
                Title = title;
            }
        }

        public class Encoder
        {
            public delegate void EncodingEventHandler(); // define delegate
            public event EncodingEventHandler EncodingDone; // define event, based on delegate

            protected virtual void OnEncodingDone()
            {
                var handler = EncodingDone;
                if (handler != null) handler();
            }

            public void Encode(Video video)
            {
                Console.WriteLine("\nStarting encoding process.");

                for (int i = 0; i <= 100; i++)
                {
                    Console.Write("\rEncoding " + video.Title + ", " + i + "%.");
                    Thread.Sleep(10);

                    if (i == 100) Console.WriteLine("");
                }

                Console.WriteLine("Finished encoding: " + video.Title + ".\n");
                OnEncodingDone(); // raising the event
            }
        }

        static void Main(string[] args)
        {
            Video myVideo = new Video("Fightclub");
            Encoder myEncoder = new Encoder();
            MailService myMailService = new MailService();

            /*Settings for event things*/
            myEncoder.EncodingDone += myMailService.OnEncodingDone;

            myEncoder.Encode(myVideo);
        }
    }
}
