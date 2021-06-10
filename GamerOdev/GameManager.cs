using System;
using System.Collections.Generic;
using System.Text;

namespace GamerOdev
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name+" Stoğa Eklendi.");
        }
    }
}
