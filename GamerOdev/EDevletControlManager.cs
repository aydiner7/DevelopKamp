using System;
using System.Collections.Generic;
using System.Text;

namespace GamerOdev
{
    class EDevletControlManager : IGamerControlService
    {
        public bool Control(Gamer gamer)
        {
            if (gamer.BirthYear == "1995" && gamer.TCNo == "123456") return true;
            else return false;
        }
    }
}
