using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Entities;

namespace CustomerManager.Entities
{
    public class CustomerEntity
    {
        public CustomerEntity(){
            Contacts = new HashSet<ContactEntity>();
        }
        public int Id {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string Phone {get; set;}
        public DateTime CreationDate {get; set;}
        
        public virtual ICollection<ContactEntity> Contacts {get; set;}
        
    }
}