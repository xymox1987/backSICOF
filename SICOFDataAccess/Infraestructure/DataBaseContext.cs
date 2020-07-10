using Microsoft.EntityFrameworkCore;
using SICOFDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SICOFDataAccess.Infraestructure
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }
        //agregando entities
        public DbSet<TaskEntity> taskEntities { get; set; }
        public DbSet<VersionEntity> versionEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new VersionEntityMap(modelBuilder.Entity<VersionEntity>());


        }
    }
}
