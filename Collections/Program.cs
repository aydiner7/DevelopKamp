using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eleman sayısı değişebilecek durumlarda dizi yerine liste kullanımı seçilmelidir.
            List<string> isimler = new List<string>
            {
                "Hasan", "Hüseyin", "Ahmet", "Veli"
            };
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
            isimler.Add("Afra");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
        }
    }
}
