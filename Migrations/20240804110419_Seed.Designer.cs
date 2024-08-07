﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelTo.Users;

#nullable disable

namespace TravelTo.Migrations
{
    [DbContext(typeof(UsersDbContext))]
    [Migration("20240804110419_Seed")]
    partial class Seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TravelTo.Models.Turebi", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("image_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Turebi");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Description = "aq iyo batoni wyali romelmac wyali dalia",
                            Name = "Antarqtida",
                            Price = 5.9900000000000002,
                            image_name = "31394_1.jpg"
                        },
                        new
                        {
                            id = 2,
                            Description = "tbilo tibifli",
                            Name = "Tbilisi",
                            Price = 15.99,
                            image_name = "65878_1.jpg"
                        },
                        new
                        {
                            id = 3,
                            Description = "parizelta dedaqali",
                            Name = "Parizi",
                            Price = 6.9900000000000002,
                            image_name = "59564_1.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
