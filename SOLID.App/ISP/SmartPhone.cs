using System;

namespace SOLID.App
{
    public class SmartPhone : IBasicPhone, IVideoPhone, IPicturePhone
    {
        public void MakeVideoCall()
        {
            Console.WriteLine("Making Video Call");
        }

        public void MakeVoiceCall()
        {
            Console.WriteLine("Making Voice Call");
        }

        public void SendSmsMessage()
        {
            Console.WriteLine("Sending SMS Message");
        }

        public void TakePicture()
        {
            Console.WriteLine("Taking Picture");
        }
    }
}
