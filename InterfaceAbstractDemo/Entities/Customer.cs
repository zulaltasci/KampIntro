using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }

    }
}
