using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsVideo
{
    class MessageWhatsapp
    {
        public void SendWhatsapp(Video video)
        {
            Console.WriteLine($"Sending Whatsapp ...... for complitaion of video {video.Title}");
        }
    }
}
