using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Entities;

namespace CustomerManager.Entities
{
    public class CustomerEntity
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Addres {get; set;}
        public int Number {get; set;}
        public DateTime CreateDate {get; set;}
        
        public ICollection<ContactEntity> Contacts {get; set;}
        
    }
}