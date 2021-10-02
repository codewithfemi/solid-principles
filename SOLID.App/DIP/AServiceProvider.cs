using System;

namespace SOLID.App
{
    public class AServiceProvider : ISmsServiceProvider
    {
        public void SendSms(string cellPhone)
        {
            throw new Exception();
            Console.WriteLine($"Sending SMS to cell phone: {cellPhone}");
        }
    }
}
