using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using task.Models;

namespace task.Context
{
    public class myContext:DbContext
    {
    public myContext(DbContextOptions<myContext> options) : base(options)
    { }
    
    public DbSet<EquipmentDetails> EquipmentDetails { get; set; }
    public DbSet<transportDetail> transportDetail { get; set; }
    public DbSet<BusinessPartner> BusinessPartner { get; set; }
    public DbSet<DepotDetail> DepotDetail { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(myContext).Assembly);
      
    }
    }

}

 
