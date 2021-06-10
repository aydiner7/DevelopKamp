using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCeditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }

        public void PrintOut()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Çıktı Alındı.");
        }
    }
}
