using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Models;
using CustomerManager.Entities;

namespace CustomerManager.Mappers
{
    public class ContactsMapper
    {
        public static ContactsModel Map(ContactEntity entity){
            return new ContactsModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address,
                Phone = entity.Phone,
                CustomerId = entity.CustomerId
                
            };
        }  
        public static ContactEntity Map(ContactsModel entity){
            return new ContactEntity()
            {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address,
                Phone = entity.Phone,
                CustomerId = entity.CustomerId
            };
        }  
    }
}