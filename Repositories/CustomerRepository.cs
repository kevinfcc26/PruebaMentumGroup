using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Entities;

namespace CustomerManager.Repositories
{
    public class CustomerRepository 
    {
        //CRUD --> CREATE READ UPDATE DELETE
        private readonly MentumGroupDBContext _mentumGroupDBContext;

        public CustomerRepository(MentumGroupDBContext mentumGroupDBContext)
        {
            _mentumGroupDBContext = mentumGroupDBContext;
        }

        public async Task<CustomerEntity> Add(CustomerEntity entity)
        {
            await _mentumGroupDBContext.Customers.AddAsync(entity);

            await _mentumGroupDBContext.SaveChangesAsync();

            return entity;
        }
        public async Task<CustomerEntity> Get(int identity)
        {
            var result = await _mentumGroupDBContext.Customers.FirstOrDefaultAsync(x => x.Id == identity);

            return result;
        }
        public async Task<CustomerEntity> Update(int identity, CustomerEntity updateEnt)
        {
            var entity = await Get(identity);

            entity.Name = updateEnt.Name;

            _mentumGroupDBContext.Customers.Update(entity);

            await _mentumGroupDBContext.SaveChangesAsync();

            return entity;
        }
        public async Task<CustomerEntity> Update(CustomerEntity entity)
        {
            var updateEntity = _mentumGroupDBContext.Customers.Update(entity);

            await _mentumGroupDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        
        
        public async Task DeleteAsync(int identity)
        {
            var entity = await _mentumGroupDBContext.Customers.SingleAsync(x => x.Id == identity);
            _mentumGroupDBContext.Customers.Remove(entity);

            await _mentumGroupDBContext.SaveChangesAsync();
        }

        public Task<bool> Exit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerEntity>> GetAll()
        {
            return _mentumGroupDBContext.Customers.Select(x => x);
        }
    }
}
