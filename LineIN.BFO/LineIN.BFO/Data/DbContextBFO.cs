using LineIN.BFO.Data.Mapping;
using LineIN.BFO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineIN.BFO.Data
{
    public class DbContextBFO: DbContext
    {
        public DbContextBFO(DbContextOptions<DbContextBFO> optins) : base(optins)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
    }
}
