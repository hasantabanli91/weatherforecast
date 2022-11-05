using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography;
using weatherforecast.Entities;

namespace weatherforecast.DAL
{
    public class DataBaseContext : DbContext
    {
        //public DbSet<Kullanici> Kullanici { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("PGSQL_CONNECTION_STRING") ?? "host=127.0.0.1;port=5432;database=HobiVoll;user id=postgres;password=pass123");
            //                                                                                         Server=localhost;Database=HobiVoll;Port=5432;User Id=postgres;Password=pass123;
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=localhost;database=Weather;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<WeatherForecast>().HasKey(k => k.Id);
        }
    }
}