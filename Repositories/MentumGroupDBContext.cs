using Microsoft.EntityFrameworkCore;
using CustomerManager.Entities;
using CustomerManager.Entities.EntityConfig;

namespace CustomerManager.Repositories
{
    public class MentumGroupDBContext: DbContext
    {
        public DbSet<CustomerEntity> Customers {get; set;}
        public DbSet<ContactEntity> Contacts {get; set;}

        public MentumGroupDBContext(DbContextOptions options): base (options) 
        {
            
        }
        public MentumGroupDBContext()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerEntityconfig.SetEntityBuilder(modelBuilder.Entity<CustomerEntity>());
            ContactEntityconfig.SetEntityBuilder(modelBuilder.Entity<ContactEntity>());
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
