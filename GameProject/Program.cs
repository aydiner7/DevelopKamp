using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() 
            {
                FirstName="Hasan",
                BirthYear=1995,
                LastName="AYDINER",
                IdentithNumber=123456
            };

            Gamer gamer2 = new Gamer()
            {
                FirstName = "Hasan",
                BirthYear = 1993,
                LastName = "AYDINER",
                IdentithNumber = 123456
            };

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer2);
        }
    }
}
