using System;

namespace SOLID.App
{
    public class AServiceProvider : ISmsServiceProvider
    {
        public void SendSms(string cellPhone)
        {
            Console.WriteLine($"Sending SMS to cell phone: {cellPhone}");
        }
    }
}
