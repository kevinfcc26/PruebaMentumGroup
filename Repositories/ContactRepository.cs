using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Entities;

namespace CustomerManager.Repositories
{
    public class ContactRepository 
    {
        //CRUD --> CREATE READ UPDATE DELETE
        private readonly MentumGroupDBContext _mentumGroupDBContext;

        public ContactRepository(MentumGroupDBContext mentumGroupDBContext)
        {
            _mentumGroupDBContext = mentumGroupDBContext;
        }

        public async Task<ContactEntity> Add(ContactEntity entity)
        {
            await _mentumGroupDBContext.Contacts.AddAsync(entity);

            await _mentumGroupDBContext.SaveChangesAsync();

            return entity;
        }
        public async Task<ContactEntity> Get(int identity)
        {
            var result = await _mentumGroupDBContext.Contacts.FirstOrDefaultAsync(x => x.Id == identity);

            return result;
        }
        public async Task<ContactEntity> Update(int identity, ContactEntity updateEnt)
        {
            var entity = await Get(identity);

            entity.Name = updateEnt.Name;

            _mentumGroupDBContext.Contacts.Update(entity);

            await _mentumGroupDBContext.SaveChangesAsync();

            return entity;
        }
        public async Task<ContactEntity> Update(ContactEntity entity)
        {
            var updateEntity = _mentumGroupDBContext.Contacts.Update(entity);

            await _mentumGroupDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        
        
        public async Task DeleteAsync(int identity)
        {
            var entity = await _mentumGroupDBContext.Contacts.SingleAsync(x => x.Id == identity);
            _mentumGroupDBContext.Contacts.Remove(entity);

            await _mentumGroupDBContext.SaveChangesAsync();
        }

        public Task<bool> Exit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<ContactEntity>> GetAll()
        {
            return _mentumGroupDBContext.Contacts.Select(x => x).ToList();
        }
        public async Task<IEnumerable<ContactEntity>> getForId(int id){
            return _mentumGroupDBContext.Contacts.Where(x => x.CustomerId == id);
        }
    }
}
