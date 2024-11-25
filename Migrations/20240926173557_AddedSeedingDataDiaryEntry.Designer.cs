﻿// <auto-generated />
using System;
using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240926173557_AddedSeedingDataDiaryEntry")]
    partial class AddedSeedingDataDiaryEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.1.24451.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiaryApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Went hiking with joe",
                            Created = new DateTime(2024, 9, 26, 23, 5, 57, 90, DateTimeKind.Local).AddTicks(8397),
                            Title = "Went Hiking"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Went Shopping with joe",
                            Created = new DateTime(2024, 9, 26, 23, 5, 57, 90, DateTimeKind.Local).AddTicks(8664),
                            Title = "Went Shopping"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Went Diving with joe",
                            Created = new DateTime(2024, 9, 26, 23, 5, 57, 90, DateTimeKind.Local).AddTicks(8666),
                            Title = "Went Divivg"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Went Dancing with joe",
                            Created = new DateTime(2024, 9, 26, 23, 5, 57, 90, DateTimeKind.Local).AddTicks(8667),
                            Title = "Went Dancing"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}