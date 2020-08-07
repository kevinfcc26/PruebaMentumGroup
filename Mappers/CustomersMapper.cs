using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Models;
using CustomerManager.Entities;

namespace CustomerManager.Mappers
{
    public class CustomersMapper
    {
        public static CustomerModel Map(CustomerEntity entity){
            return new CustomerModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Addres = entity.Addres,
                Number = entity.Number,
                CreateDate = entity.CreateDate
            };
        }  
        public static CustomerEntity Map(CustomerModel entity){
            return new CustomerEntity()
            {
                Id = entity.Id,
                Name = entity.Name,
                Addres = entity.Addres,
                Number = entity.Number,
                CreateDate = entity.CreateDate
            };
        }  
    }
}