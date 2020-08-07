using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Models
{
    public class ContactsModel
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Addres {get; set;}
        public int Number {get; set;}
        public CustomerModel Customer {get; set;}
    }
}