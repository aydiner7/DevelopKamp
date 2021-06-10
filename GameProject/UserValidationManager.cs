using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "Hasan" && gamer.LastName == "AYDINER" && gamer.IdentithNumber == 123456)
            {
                return true;
            }
            else return false;
        }
    }
}
