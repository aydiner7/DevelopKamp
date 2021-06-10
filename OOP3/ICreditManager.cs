using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceler kuralları içerir ve kullanmak isteyen classlar kurallara uyarlar.
    // İçerisine yazacağım imza methotlarını hangi classa implamente edersem, o class bu methotları içermek zorundadır.
    // Okunurluğu belirginleştirmek için Büyük i harfi ile başlarlar. " I "
    // İnterfaceler de, implamante eden classın referans kodunu tutarlar.
    // İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

    // Bu çalışmamda tüm kredi türlerimin hesaplanması vardır ama her kredinin hesaplanması farklıdır.
    interface ICreditManager
    {

        public void Calculate();

        public void PrintOut();
    }


}
