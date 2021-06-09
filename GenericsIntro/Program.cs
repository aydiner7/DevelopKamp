using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Hasan");
            myList.Add("Afra");
            myList.Add("Ahmet");
            myList.Add("Veli");
        }
    }
}
