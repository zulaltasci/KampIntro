using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Game
    {
        /// <summary>
        /// Oyunun özelliklerini tanımladım.
        /// (I defined the proparty of the game)
        /// </summary>
        public string GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
