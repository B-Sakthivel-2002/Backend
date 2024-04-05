using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using task.Models;

namespace task.Configurations
{
    public class transportConfiguration : IEntityTypeConfiguration<transportDetail>
    {
        public void Configure(EntityTypeBuilder<transportDetail> builder)
        {
         builder.HasKey(c => c.transportId);
          
           builder.Property(e=>e.transportId)
            .HasColumnName("transportId")
            .HasColumnType("int")
            .IsRequired();

            
      
            builder.Property(e=>e.transportCompany)
            .HasColumnName("transportCompany")
            .HasColumnType("varchar(20)")
            .HasMaxLength(20)
            .IsRequired();
            builder.Property(e=>e.licenseNo)
            .HasColumnName("licenseNo")
            .HasColumnType("varchar(20)")
            .HasMaxLength(20)
            .IsRequired();
            builder.Property(e=>e.driverName)
            .HasColumnName("driverName")
            .HasColumnType("varchar(20)")
            .HasMaxLength(20)
            .IsRequired();
            builder.Property(e=>e.driverMobileNo)
            .HasColumnName("driverMobileNo")
            .HasColumnType("int")
            .HasMaxLength(10)
            .IsRequired();
            builder.Property(e=>e.driverEmail)
            .HasColumnName("driverEmail")
            .HasColumnType("varchar(25)")
            .HasMaxLength(25)
            .IsRequired();
        }
    }
}