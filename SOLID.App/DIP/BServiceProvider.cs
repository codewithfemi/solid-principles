using System;

namespace SOLID.App
{
    public class BServiceProvider : ISmsServiceProvider
    {
        public void SendSms(string cellPhone)
        {
            throw new Exception("Broken");
            Console.WriteLine($"Sending SMS to cell phone: {cellPhone}");
        }
    }
}
