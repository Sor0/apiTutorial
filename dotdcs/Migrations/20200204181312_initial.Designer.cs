﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotdcs.Context;

namespace dotdcs.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20200204181312_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("dotdcs.Models.Credit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Interest")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSpecial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Term")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("dotdcs.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DocumentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("WalletId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("dotdcs.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<int>("CreditId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreditId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("dotdcs.Models.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IntialBalance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("UploadPercent")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("dotdcs.Models.Credit", b =>
                {
                    b.HasOne("dotdcs.Models.Customer", "customer")
                        .WithMany("credits")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotdcs.Models.Customer", b =>
                {
                    b.HasOne("dotdcs.Models.Wallet", "wallet")
                        .WithMany("customers")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotdcs.Models.Payment", b =>
                {
                    b.HasOne("dotdcs.Models.Credit", "credit")
                        .WithMany()
                        .HasForeignKey("CreditId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
