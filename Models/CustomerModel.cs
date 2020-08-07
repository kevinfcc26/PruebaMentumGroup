using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Models
{
    public class CustomerModel
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Addres {get; set;}
        public int Number {get; set;}
        public DateTime CreateDate {get; set;}
        public ICollection<ContactsModel> Contacts {get; set;}

    }
}