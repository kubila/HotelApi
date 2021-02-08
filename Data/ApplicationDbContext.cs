using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Turkey",
                    ShortName = "TR"
                },
                new Country
                {
                    Id = 2,
                    Name = "Italy",
                    ShortName = "IT"
                },
                new Country
                {
                    Id = 3,
                    Name = "Spain",
                    ShortName = "SP"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Royal Wings Hotel Antalya",
                    Address = "Yeni Turizm Yolu Lara, Antalya, Turkey",
                    Rating = 9.6,
                    CountryId = 1,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "QT Suites & Apartments - Sistina",
                    Address = "Via Sistina, 57, Rome, 00187, Italy",
                    Rating = 10.0,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Hotel Central - Small Luxury Hotels of the World",
                    Address = "Via Laietana 30, Barcelona, 08003, Spain",
                    Rating = 9.6,
                    CountryId = 3
                }
                );
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }
    }
}
