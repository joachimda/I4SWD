using System;

namespace HowTo_Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        /* How to do Event
         * 
         * 1: Define delegate
         * 2: Define event based on delegate
         * 3: Raise event 
         *
         */

        // 1: Define delegate
        public delegate void VideoEncodedEventHandler(object source /*sender of the event*/, VideoEventArgs args /*additional data*/);

        // 2: Define event based on delegate
        public event VideoEncodedEventHandler VideoEncoded;

        // 3: Raise event
        protected virtual void OnVideoEncoded(Video video) /*Convention: function to be called on event is called On<EventName>*/
        {
            if (VideoEncoded != null) /*Checking if there are any subscribers, optimization only...*/
            {
                VideoEncoded(this, new VideoEventArgs(){Video = video});   /* Explanation
                                                                            * this,             ref to the sending object
                                                                            * EventArgs.Empty   used if there are no additional data
                                                                            */
            }
        }

        public void Encode(Video video)
        {
            Console.Write("Encoding Video... ");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Done!");

            OnVideoEncoded(video); // raising evnet
        } 
    }
}