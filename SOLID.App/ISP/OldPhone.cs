using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App
{
    // NOKIA 3310
    public class OldPhone : IBasicPhone
    {
        public void MakeVoiceCall()
        {
            Console.WriteLine("Making Voice Call");
        }

        public void SendSmsMessage()
        {
            Console.WriteLine("Sending SMS Message");
        }
    }
}
