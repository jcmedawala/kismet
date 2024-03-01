﻿// <auto-generated />
using System;
using BookingService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookingService.Data.Migrations
{
    [DbContext(typeof(CoreDataDbContext))]
    partial class CoreDataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookingService.Entities.CoreData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccountNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Agent")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LegalCountry")
                        .HasColumnType("text");

                    b.Property<string>("LegalName")
                        .HasColumnType("text");

                    b.Property<string>("RelationshipManager")
                        .HasColumnType("text");

                    b.Property<int>("ReviewType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TargetDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("CoreDatas");
                });

            modelBuilder.Entity("BookingService.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("AddedBy")
                        .HasColumnType("text");

                    b.Property<string>("BookingLegalEntity")
                        .HasColumnType("text");

                    b.Property<string>("BusinessUnit")
                        .HasColumnType("text");

                    b.Property<Guid>("CoreDataId")
                        .HasColumnType("uuid");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CoreDataId")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BookingService.Entities.Product", b =>
                {
                    b.HasOne("BookingService.Entities.CoreData", "CoreData")
                        .WithOne("Product")
                        .HasForeignKey("BookingService.Entities.Product", "CoreDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoreData");
                });

            modelBuilder.Entity("BookingService.Entities.CoreData", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}