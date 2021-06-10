using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerServers : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Gönderildi.");
        }
    }
}
