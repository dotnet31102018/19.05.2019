using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder encoder = new VideoEncoder();

            Video myDrivingVideo = new Video() { Title = "I am driving for the first time!" };

            EmailSender myEmailSender = new EmailSender();
            encoder.TheAfterFunciton = myEmailSender.SendEmail;

            MessageWhatsapp whatsapp = new MessageWhatsapp();
            encoder.TheAfterFunciton += whatsapp.SendWhatsapp;

            encoder.Encode(myDrivingVideo);
        }
    }
}
