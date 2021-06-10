using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        // Başvuru yap
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerService)
        {
            creditManager.Calculate();
            foreach (var item in loggerService)
            {
                item.Log();
            }
        }

        //Ön bilgilendirme
        //İstediği kadar kredi seçeneğini seçip, liste halinde gönderdiği zaman tek tek hesaplaması yapılır.
        public void CreditInformation(List<ICreditManager> creditManagers)
        {
            foreach (var item in creditManagers)
            {
                item.Calculate();
            }
        }
    }
}
