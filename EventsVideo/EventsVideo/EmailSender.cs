using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsVideo
{
    class EmailSender
    {
        public void SendEmail(Video video)
        {
            Console.WriteLine($"Sending email for complitaion of video {video.Title}");
        }
    }
}
