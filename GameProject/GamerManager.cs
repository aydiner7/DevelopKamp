using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{

    // Katmanlı Mimari Örneği.
    class GamerManager : IGamerService
    {

        //constructor ürettik
        IUserValidationService _userValidationService;
        //GamerManager classını bağımlı hale getirerek, kontrol altına aldık.
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Oldu.");
            }
            else Console.WriteLine("Doğrulama Başarısız, Kayıt Başarısız.!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }
    }
}
