using System;
using System.Collections.Generic;
using System.Text;

namespace GamerOdev
{
    class GamerManager : IGamerService
    {

        IGamerControlService _gamerControlService;

        public GamerManager(IGamerControlService gamerControlService)
        {
            _gamerControlService = gamerControlService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerControlService.Control(gamer) == true) Console.WriteLine("Gamer Eklendi.");
            else Console.WriteLine("Kontrol Başarısız, Gamer Eklenemedi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Güncellendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Silindi.");
        }
    }
}
