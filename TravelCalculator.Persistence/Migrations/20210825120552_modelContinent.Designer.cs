﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TravelCalculator.Persistence.Data;

namespace TravelCalculator.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210825120552_modelContinent")]
    partial class modelContinent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TravelCalculator.Domain.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ContinentId")
                        .HasColumnType("integer");

                    b.Property<string>("CountryName")
                        .HasColumnType("text");

                    b.Property<bool>("IsPopularCountry")
                        .HasColumnType("boolean");

                    b.HasKey("CountryId");

                    b.HasIndex("ContinentId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ContinentName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("RegionName")
                        .HasColumnType("text");

                    b.HasKey("RegionId");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Resort", b =>
                {
                    b.Property<int>("ResortId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.Property<string>("ResortName")
                        .HasColumnType("text");

                    b.Property<int>("Season")
                        .HasColumnType("integer");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.HasKey("ResortId");

                    b.HasIndex("RegionId");

                    b.ToTable("Resorts");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<int>("Month")
                        .HasColumnType("integer");

                    b.Property<int>("seasonType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Country", b =>
                {
                    b.HasOne("TravelCalculator.Domain.Models.Entities.Continent", null)
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Region", b =>
                {
                    b.HasOne("TravelCalculator.Domain.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Resort", b =>
                {
                    b.HasOne("TravelCalculator.Domain.Models.Entities.Region", "Region")
                        .WithMany("Resorts")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Season", b =>
                {
                    b.HasOne("TravelCalculator.Domain.Country", "Country")
                        .WithMany("Seasons")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Country", b =>
                {
                    b.Navigation("Regions");

                    b.Navigation("Seasons");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("TravelCalculator.Domain.Models.Entities.Region", b =>
                {
                    b.Navigation("Resorts");
                });
#pragma warning restore 612, 618
        }
    }
}