﻿// <auto-generated />
using System;
using Assets_Management_System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assets_Management_System.Migrations
{
    [DbContext(typeof(AssetContext))]
    partial class AssetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Assets_Management_System.ExchangeRate", b =>
                {
                    b.Property<int>("ExchangeRateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("ExchangeRateId");

                    b.ToTable("ExchangeRates");
                });

            modelBuilder.Entity("Assets_Management_System.LaptopComputer", b =>
                {
                    b.Property<int>("LaptopComputerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExchangeRate")
                        .HasColumnType("float");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LaptopComputerId");

                    b.HasIndex("OfficeId");

                    b.ToTable("LaptopComputers");
                });

            modelBuilder.Entity("Assets_Management_System.MobilePhone", b =>
                {
                    b.Property<int>("MobilePhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExchangeRate")
                        .HasColumnType("float");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MobilePhoneId");

                    b.HasIndex("OfficeId");

                    b.ToTable("MobilePhones");
                });

            modelBuilder.Entity("Assets_Management_System.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OfficeId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Assets_Management_System.LaptopComputer", b =>
                {
                    b.HasOne("Assets_Management_System.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("Assets_Management_System.MobilePhone", b =>
                {
                    b.HasOne("Assets_Management_System.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId");

                    b.Navigation("Office");
                });
#pragma warning restore 612, 618
        }
    }
}
