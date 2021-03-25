﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlantApp.Data;

namespace PlantApp.Data.Migrations
{
    [DbContext(typeof(PlantContext))]
    [Migration("20210323160717_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlantApp.Domain.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommonName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("PlantApp.Domain.PlantPlantType", b =>
                {
                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<int>("PlantTypeId")
                        .HasColumnType("int");

                    b.HasKey("PlantId", "PlantTypeId");

                    b.HasIndex("PlantTypeId");

                    b.ToTable("PlantPlantTypes");
                });

            modelBuilder.Entity("PlantApp.Domain.PlantType", b =>
                {
                    b.Property<int>("PlantTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlantTypeId");

                    b.ToTable("PlantTypes");

                    b.HasData(
                        new
                        {
                            PlantTypeId = 1,
                            Name = "Alpine"
                        },
                        new
                        {
                            PlantTypeId = 2,
                            Name = "Annual"
                        },
                        new
                        {
                            PlantTypeId = 3,
                            Name = "Biennial"
                        },
                        new
                        {
                            PlantTypeId = 4,
                            Name = "Bog"
                        },
                        new
                        {
                            PlantTypeId = 5,
                            Name = "Bulb"
                        },
                        new
                        {
                            PlantTypeId = 6,
                            Name = "Cactus"
                        },
                        new
                        {
                            PlantTypeId = 7,
                            Name = "Climber"
                        },
                        new
                        {
                            PlantTypeId = 8,
                            Name = "Conservatory"
                        },
                        new
                        {
                            PlantTypeId = 9,
                            Name = "Fruit"
                        },
                        new
                        {
                            PlantTypeId = 10,
                            Name = "Herb"
                        },
                        new
                        {
                            PlantTypeId = 11,
                            Name = "House"
                        },
                        new
                        {
                            PlantTypeId = 12,
                            Name = "Fruit"
                        },
                        new
                        {
                            PlantTypeId = 13,
                            Name = "Marginal"
                        },
                        new
                        {
                            PlantTypeId = 14,
                            Name = "Perennial"
                        },
                        new
                        {
                            PlantTypeId = 15,
                            Name = "Pond"
                        },
                        new
                        {
                            PlantTypeId = 16,
                            Name = "Shrub"
                        },
                        new
                        {
                            PlantTypeId = 17,
                            Name = "Succulent"
                        },
                        new
                        {
                            PlantTypeId = 18,
                            Name = "Tree"
                        },
                        new
                        {
                            PlantTypeId = 19,
                            Name = "Vegetable"
                        });
                });

            modelBuilder.Entity("PlantApp.Domain.PlantPlantType", b =>
                {
                    b.HasOne("PlantApp.Domain.Plant", null)
                        .WithMany()
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlantApp.Domain.PlantType", null)
                        .WithMany()
                        .HasForeignKey("PlantTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}