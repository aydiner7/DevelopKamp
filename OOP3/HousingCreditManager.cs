using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ev Kredisi Ödeme Planı Hesaplandı.");
        }

        public void PrintOut()
        {
            Console.WriteLine("Ev Kredisi Ödeme Planı Çıktı Alındı.");
        }
    }
}
