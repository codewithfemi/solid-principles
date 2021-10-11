using System;

namespace SOLID.App
{
    public class BServiceProvider : ISmsServiceProvider
    {
        public void SendSms(string cellPhone)
        {
            Console.WriteLine($"cell phone {cellPhone} was sent the sms {DateTime.UtcNow}");
            Console.WriteLine($"Sending SMS to cell phone: {cellPhone}");
        }
    }
}
