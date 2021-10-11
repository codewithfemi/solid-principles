using System;

namespace SOLID.App
{
    public class BServiceProvider : ISmsServiceProvider
    {
        public void SendSms(string cellPhone)
        {
            Console.WriteLine($"Logging cell phone {cellPhone} - {DateTime.UtcNow}");
            Console.WriteLine($"Sending SMS to cell phone: {cellPhone}");
        }
    }
}
