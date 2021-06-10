using System;
using System.Collections.Generic;
using System.Text;

namespace GamerOdev
{
    class FacebookControlManager : IGamerControlService
    {
        public bool Control(Gamer gamer)
        {
            if (gamer.FirstName == "Hasan" && gamer.LastName == "AYDINER") return true;
            else return false;
        }
    }
}
