using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " ismindeki oyun eklendi!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " ismindeki oyun silindi!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " ismindeki oyun güncellendi!");
        }
    }
}
