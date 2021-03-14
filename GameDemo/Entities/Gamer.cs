using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public  class Gamer
    {
        /// <summary>
        /// Oyuncunun özelliklerini tanımladım.
        /// (I have defined the proparty of the player)
        /// </summary>
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
