using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PlantApp.Data.Configurations;
using PlantApp.Domain;
using System;
using System.Collections.Generic;
using System.IO;

namespace PlantApp.Data
{
    public class PlantContext : DbContext
    {
        private readonly string _connectionString;
        private readonly bool _useConsoleLogger;

        public DbSet<Plant> Plants { get; set; }    
        public DbSet<PlantType> PlantTypes { get; set; }
        public DbSet<PlantPlantType> PlantPlantTypes { get; set; }

        //public DbSet<Hardiness> Hardiness { get; set; }
        //public DbSet<SoilType> SoilTypes { get; set; }
        //public DbSet<SunExposure> SunExposures { get; set; }



        public PlantContext(string connectionString
                            , bool useConsoleLogger)
        {
            _connectionString = connectionString;
            _useConsoleLogger = useConsoleLogger;
        }

        public PlantContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(_connectionString);
                //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            if (_useConsoleLogger)
            {
                optionsBuilder
                    .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                    .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Plant>()
            .HasMany(p => p.PlantTypes)
            .WithMany(p => p.Plants)
            .UsingEntity<PlantPlantType>
              (ppt => ppt.HasOne<PlantType>().WithMany(),
               ppt => ppt.HasOne<Plant>().WithMany());

             modelBuilder.Entity<PlantType>().HasData(SeedDataFromJson<PlantType>("../PlantApp.Data/SeedData/PlantTypes.json"));

        }
        public static List<T> SeedDataFromJson<T>(string seedDataJsonLocation)
        {
            List<T> tests = new List<T>();
            using (StreamReader r = new StreamReader(@seedDataJsonLocation))
            {
                string json = r.ReadToEnd();
                tests = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return tests;
        }
 
    }
}
