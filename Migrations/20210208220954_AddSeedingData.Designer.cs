﻿// <auto-generated />
using HotelApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210208220954_AddSeedingData")]
    partial class AddSeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("HotelApi.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Turkey",
                            ShortName = "TR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Italy",
                            ShortName = "IT"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Spain",
                            ShortName = "SP"
                        });
                });

            modelBuilder.Entity("HotelApi.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Yeni Turizm Yolu Lara, Antalya, Turkey",
                            CountryId = 1,
                            Name = "Royal Wings Hotel Antalya",
                            Rating = 9.5999999999999996
                        },
                        new
                        {
                            Id = 2,
                            Address = "Via Sistina, 57, Rome, 00187, Italy",
                            CountryId = 2,
                            Name = "QT Suites & Apartments - Sistina",
                            Rating = 10.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Via Laietana 30, Barcelona, 08003, Spain",
                            CountryId = 3,
                            Name = "Grand Hotel Central - Small Luxury Hotels of the World",
                            Rating = 9.5999999999999996
                        });
                });

            modelBuilder.Entity("HotelApi.Data.Hotel", b =>
                {
                    b.HasOne("HotelApi.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelApi.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
