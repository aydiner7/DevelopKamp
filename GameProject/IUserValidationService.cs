using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // Kullanıcı Doğrulama Servisi
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
