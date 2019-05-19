using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsVideo
{
    class VideoEncoder
    {

        public delegate void MyActionVideo(Video v);
        public MyActionVideo TheAfterFunciton { get; set; }

        // Publisher

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding {video.Title}");
            Thread.Sleep(3000);

            // Send email
            //Console.WriteLine("Sending email...");

            // Send message 
            //Console.WriteLine("Sending message...");

            // Invoke method
            if (TheAfterFunciton != null)
            {
                TheAfterFunciton.Invoke(video);
            }
        }
    }
}
