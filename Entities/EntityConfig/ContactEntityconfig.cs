using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Entities.EntityConfig
{
    public class ContactEntityconfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ContactEntity> entityBuilder){

            entityBuilder.ToTable("Contact");
            
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .IsRequired()
                         .HasColumnName("Id")
                         .HasColumnType("int");

            entityBuilder.HasOne(x => x.Customer)
                         .WithMany(x => x.Contacts)
                         .HasForeignKey(x => x.CustomerId);

        }
        
    }
}