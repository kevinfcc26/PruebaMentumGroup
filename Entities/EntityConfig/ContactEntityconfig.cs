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
            
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .IsRequired();

            entityBuilder.Property(e => e.Address)
                         .HasMaxLength(100)
                         .IsFixedLength(true);

            entityBuilder.Property(e => e.Name)
                         .IsRequired()
                         .HasMaxLength(50)
                         .IsFixedLength(true);

            entityBuilder.Property(e => e.Phone)
                         .HasMaxLength(10)
                         .IsFixedLength(true);

            entityBuilder.HasOne(d => d.Customer)
                         .WithMany(p => p.Contacts)
                         .HasForeignKey(x => x.CustomerId)
                         .OnDelete(DeleteBehavior.ClientSetNull)
                         .HasConstraintName("FK_Contacts_Customers");
        }
        
    }
}