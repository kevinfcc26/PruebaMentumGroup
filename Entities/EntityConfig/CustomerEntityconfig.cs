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

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id)
                         .IsRequired()
                         .HasColumnName("Id")
                         .HasColumnType("int");
            entityBuilder.Property(e => e.Address)
                         .HasMaxLength(50)
                         .IsFixedLength(true);

            entityBuilder.Property(e => e.CreationDate)
                         .HasColumnType("datetime")
                         .HasAnnotation("Relational:ColumnType", "datetime");

            entityBuilder.Property(e => e.Name)
                         .IsRequired()
                         .HasMaxLength(50)
                         .IsFixedLength(true);
            
            entityBuilder.Property(e => e.Phone)
                         .IsRequired()
                         .HasMaxLength(10)
                         .IsFixedLength(true);

        }
        
    }
}