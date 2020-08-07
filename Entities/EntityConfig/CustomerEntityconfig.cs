using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Entities.EntityConfig
{
    public class CustomerEntityconfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<CustomerEntity> entityBuilder){

            entityBuilder.ToTable("Customers");
            
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .IsRequired()
                         .HasColumnName("Id")
                         .HasColumnType("int");

            entityBuilder.HasMany(x => x.Contacts)
                         .WithOne(x => x.Customer)
                         .HasForeignKey(x => x.CustomerId);

        }
        
    }
}