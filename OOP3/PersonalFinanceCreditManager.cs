using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }

        public void PrintOut()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Çıktı Alındı.");
        }
    }
}
