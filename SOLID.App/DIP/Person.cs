namespace SOLID.App
{
    public class Person
    {
        private readonly ISmsServiceProvider _smsServiceProvider;

        public Person(ISmsServiceProvider smsServiceProvider)
        {
            _smsServiceProvider = smsServiceProvider;
        }

        public void DeliverMessage(string cellphone)
        {
            _smsServiceProvider.SendSms(cellphone);
        }
    }
}
