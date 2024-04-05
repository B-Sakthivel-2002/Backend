using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using task.Models;

namespace task.Configurations
{
    public class equipmentConfiguration : IEntityTypeConfiguration<EquipmentDetails>
    {
        public void Configure(EntityTypeBuilder<EquipmentDetails> builder)
        {
           builder.HasKey(c => c.equipmentId);
          
           builder.Property(e=>e.equipmentId)
            .HasColumnName("equipmentId")
            .HasColumnType("int")
            .IsRequired();

            
      
            builder.Property(e=>e.equipmentNo)
            .HasColumnName("equipmentNo")
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .IsRequired();

            builder.Property(e=>e.equipmentSize)
            .HasColumnName("equipmentSize")
            .HasColumnType("int")
            .IsRequired();

          builder.Property(e=>e.equipmentLinerId)
            .HasColumnName("equipmentLinerId")
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .IsRequired();
          
          builder.Property(e=>e.depotId)
            .HasColumnName("depotId")
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .IsRequired();

          builder.Property(e=>e.conTrackingNo)
            .HasColumnName("conTrackingNo")
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .IsRequired();
         builder.Property(e => e.gateInDateTime)
                .HasColumnName("gateInDateTime")
                .IsRequired() 
                .HasColumnType("datetime") ;
          builder.Property(e=>e.ReferenceNo)
            .HasColumnName("ReferenceNo")
            .HasColumnType("varchar(10)")
            .HasMaxLength(10)
            .IsRequired();
        }
    }
}