using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CS_EFCORE.Models;

namespace CS_EFCORE.Models
{
    class PersonDBContext:DbContext
    {
        public DbSet<PersonInfo> Person { get; set; }
        public PersonDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAB1-21; Initial Catalog=PersonInfo;Integrated Security=SSPI");

        }
        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonInfo>();
        }

    }
}
