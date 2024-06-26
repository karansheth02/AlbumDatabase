﻿// <auto-generated />
using System;
using AlbumApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlbumApp.Migrations
{
    [DbContext(typeof(AlbumsDbContext))]
    [Migration("20240619010509_initialmig")]
    partial class initialmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AlbumApp.Entities.Album", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Song")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "The Clash",
                            Rating = 9.8m,
                            Song = "Lost In The Supermarket",
                            Title = "To Seek the Truth of The Cosmos"
                        },
                        new
                        {
                            Id = 2,
                            Author = "George Harrison",
                            Rating = 9.5m,
                            Song = "All Things Must Pass",
                            Title = "Beyond The Veil of Time"
                        },
                        new
                        {
                            Id = 3,
                            Author = "The Beatles",
                            Rating = 9.5m,
                            Song = "Let It Be",
                            Title = "Bad Company"
                        },
                        new
                        {
                            Id = 4,
                            Author = "John Lennon",
                            Rating = 9.1m,
                            Song = "Imagine",
                            Title = "Ready, Set, Go!"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Elton John",
                            Rating = 8.8m,
                            Song = "Your Song",
                            Title = "The Rhythm of Life"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
