using System;

namespace SOLID.App
{
    // TODO: A Service not working as expected,
    // please fix before the 15th of October 2021
    public class AServiceProvider : ISmsServiceProvider
    {
        public void SendSms(string cellPhone)
        {
            throw new Exception();
            Console.WriteLine($"Sending SMS to cell phone: {cellPhone}");
        }
    }
}
