using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestPostgres.Models;

namespace TestPostgres.DataAccess
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {
        }

        public DbSet<Patient> patients { get; set; }
        public DbSet<User_Auth> User_Auth { get; set; }
        public DbSet<Company_Details> Company_Details { get; set; }
        public DbSet<Distributer_Auth> Distributer_Auth { get; set; }
        public DbSet<Distributer_Details> Distributer_Details { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Genset_incoming_data> Genset_incoming_data { get; set; }
        public DbSet<Genset_Relation> Genset_Relation { get; set; }
        public DbSet<Manufacturer_Auth> Manufacturer_Auth { get; set; }
        public DbSet<Manufacturer_Details> Manufacturer_Details { get; set; }
        public DbSet<Superuser_Auth> Superuser_Auth { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Genset_incoming_data>().HasKey(t => new { t.Genset_Sr_No, t.Timestamp });

        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
