using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Models
{
    public class ViewModel
    {
        public IEnumerable<CustomerModel> ieCustomerModels {get; set;}
        public CustomerModel customerModels {get; set;}
        public ContactsModel contactModel {get; set;}
    }
}