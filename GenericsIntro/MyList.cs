using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // Kullanıcı listesindeki item türünü kendi belirleyebilir. "T" onu temsil eder.
    class MyList<T>
    {
        T[] items;

        // Constructor Classı nerede New lersen, bu methot orada otomatik çalışır.
        public MyList()
        {
            items = new T[0];
        }


        // Her new lediğimizde bellekteki referans kodu değişir ve eski elemanlar kaybolur.
        // Burada eleman kaybını önlemek için geçici değişkene atadık ve işlem sonrasında geri aldık.
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            // eleman eklendi.
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        
    }
}
