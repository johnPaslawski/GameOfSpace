﻿// <auto-generated />
using System;
using GameOfSpace.EFCore.EFData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameOfSpace.EFCore.Migrations
{
    [DbContext(typeof(GameOfSpaceDbContext))]
    [Migration("20211106185945_order_of_properties")]
    partial class order_of_properties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameOfSpace.Domain.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PlanetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfBuilt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("UnderConstruction")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BuildingTypeId");

                    b.HasIndex("PlanetId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.BuildingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BuildingTypes");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.CentralStar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SunMass")
                        .HasColumnType("int");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CentralStars");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxTemp")
                        .HasColumnType("int");

                    b.Property<int>("MinTemp")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlanetarySystemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanetarySystemId");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.PlanetarySystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentralStarId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CentralStarId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("PlanetarySystems");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Exp")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatsId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StatsId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.Building", b =>
                {
                    b.HasOne("GameOfSpace.Domain.Models.BuildingType", "BuildingType")
                        .WithMany()
                        .HasForeignKey("BuildingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameOfSpace.Domain.Models.Planet", "Planet")
                        .WithMany("Buildings")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BuildingType");

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.Planet", b =>
                {
                    b.HasOne("GameOfSpace.Domain.Models.PlanetarySystem", "PlanetarySystem")
                        .WithMany("Planets")
                        .HasForeignKey("PlanetarySystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlanetarySystem");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.PlanetarySystem", b =>
                {
                    b.HasOne("GameOfSpace.Domain.Models.CentralStar", "CentralStar")
                        .WithOne("PlanetarySystem")
                        .HasForeignKey("GameOfSpace.Domain.Models.PlanetarySystem", "CentralStarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameOfSpace.Domain.Models.User", "User")
                        .WithMany("PlanetarySystems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CentralStar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.User", b =>
                {
                    b.HasOne("GameOfSpace.Domain.Models.Stats", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.CentralStar", b =>
                {
                    b.Navigation("PlanetarySystem");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.Planet", b =>
                {
                    b.Navigation("Buildings");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.PlanetarySystem", b =>
                {
                    b.Navigation("Planets");
                });

            modelBuilder.Entity("GameOfSpace.Domain.Models.User", b =>
                {
                    b.Navigation("PlanetarySystems");
                });
#pragma warning restore 612, 618
        }
    }
}
