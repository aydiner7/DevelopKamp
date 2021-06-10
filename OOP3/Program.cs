using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager manager1 = new HousingCreditManager();
            ICreditManager manager2 = new VehicleCeditManager();
            ICreditManager manager3 = new PersonalFinanceCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();

            List<ILoggerService> loggerServices = new List<ILoggerService>()
            {
                new SmsLoggerServers(), new DatabaseLoggerService()
            };

            applicationManager.MakeAnApplication(new HousingCreditManager(), loggerServices);

            //applicationManager.MakeAnApplication(manager2);
            //applicationManager.MakeAnApplication(manager3);

            // Tek tek hesaplamak yerine, hesaplanmasını istediklerimi seçip tek seferde hesaplattım.
            List<ICreditManager> creditManagers = new List<ICreditManager>()
            {
                manager1, manager2, manager3
            };

            //applicationManager.CreditInformation(creditManagers);
        }
    }
}
