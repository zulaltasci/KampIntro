using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
