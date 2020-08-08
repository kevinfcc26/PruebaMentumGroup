using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Entities;


namespace CustomerManager.Entities
{
    public class ContactEntity
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string Phone {get; set;}
        public int CustomerId {get; set;}
        public CustomerEntity Customer {get; set;}
    }
}