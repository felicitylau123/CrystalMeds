﻿// <auto-generated />
using System;
using CrystalMeds.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrystalMeds.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrystalMeds.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "656a7701-7973-49bb-adc9-793f12bdcfb2",
                            Email = "admin@localhost.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECuuMJFenXmlu+HLl8PWaphTdYs5lCpwy6vQxngLfjkP1KGfqyQz03AOttWT0DIjjA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eb777c5a-b062-4616-bcd2-abcd95e922f5",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        });
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "skin care"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "First Aid"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Pain Relief"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Medicine(description needed)"
                        });
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("OrderId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<float?>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<float?>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrescriptionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("ProductPrice")
                        .HasColumnType("real");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ProductCategory = "skin care",
                            ProductDescription = "Neutrogena Hydro Boost Water Gel Cleanser",
                            ProductName = "Crystal meds skin cleanser",
                            ProductPrice = 15f
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            ProductCategory = "skin care",
                            ProductDescription = "Clinique Dramatically Different Moisturizing Lotion+",
                            ProductName = "crystal meds skin moisturizers",
                            ProductPrice = 22f
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            ProductCategory = "skin care",
                            ProductDescription = "EltaMD UV Clear Broad-Spectrum SPF 46",
                            ProductName = "crystal meds sun screen",
                            ProductPrice = 12f
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            ProductCategory = "skin care",
                            ProductDescription = "The Ordinary Niacinamide 10% + Zinc 1%",
                            ProductName = "crystal meds serum",
                            ProductPrice = 20f
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            ProductCategory = "skin care",
                            ProductDescription = "Skin Perfecting 2% BHA Liquid Exfoliant",
                            ProductName = "crystal meds exfoliants",
                            ProductPrice = 30f
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            ProductCategory = "skin care",
                            ProductDescription = "for a healthy and glow skin",
                            ProductName = "crystal meds charcoal mask",
                            ProductPrice = 30f
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2,
                            ProductCategory = "first aid",
                            ProductDescription = "and-Aid for covering small cuts and wounds.",
                            ProductName = "crystal meds adhesive bandages",
                            ProductPrice = 5f
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2,
                            ProductCategory = "first aid",
                            ProductDescription = "highest quality cotton for applying ointments or cleaning small areas.",
                            ProductName = "crystal meds cotton roll",
                            ProductPrice = 5f
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2,
                            ProductCategory = "first aid",
                            ProductDescription = "Used for cleaning wounds to prevent infection.",
                            ProductName = "crystal meds antiseptic solution",
                            ProductPrice = 13f
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2,
                            ProductCategory = "first aid",
                            ProductDescription = "eye cream with the essence of avocado for better result",
                            ProductName = "crystal meds eye cream",
                            ProductPrice = 10f
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 2,
                            ProductCategory = "first aid",
                            ProductDescription = "high quality gloves. available in all sizes",
                            ProductName = "crystal meds medical gloves",
                            ProductPrice = 15f
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 3,
                            ProductCategory = "pain relief",
                            ProductDescription = "relieves pains associated with bones and muscles",
                            ProductName = "crystal meds pain relief spray",
                            ProductPrice = 10f
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 3,
                            ProductCategory = "pain relief",
                            ProductDescription = "releives strong headache. faster action.",
                            ProductName = "crystal meds headache balm",
                            ProductPrice = 10f
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "Used for mild to moderate pain and to reduce fever. It's generally considered safe when taken as directed, but excessive use can lead to liver damage.",
                            ProductName = "Acetaminophen (Tylenol)",
                            ProductPrice = 20f
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = " formulated specifically for migraines may contain a combination of pain relievers and caffeine.",
                            ProductName = "Advil Migraine",
                            ProductPrice = 18f
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "Over-the-counter muscle relaxants can help alleviate muscle spasms and tension. ",
                            ProductName = "Zanaflex (Tizanidine)",
                            ProductPrice = 15f
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "help relieve sneezing, runny nose, and itchy or watery eyes. It may cause drowsiness.",
                            ProductName = "Robaxin (Methocarbamol)",
                            ProductPrice = 15f
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "help relieve sneezing, runny nose, and itchy or watery eyes. It may cause drowsiness.",
                            ProductName = "Benadryl",
                            ProductPrice = 15f
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "Non-drowsy options for allergy symptoms that may accompany a cold.",
                            ProductName = "Zyrtec",
                            ProductPrice = 15f
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "for fever and associated symptoms",
                            ProductName = "Aleve",
                            ProductPrice = 17f
                        },
                        new
                        {
                            ProductId = 21,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "reduces fever",
                            ProductName = "panadol",
                            ProductPrice = 10f
                        },
                        new
                        {
                            ProductId = 22,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = " Stimulate the pancreas to release more insulin.",
                            ProductName = "Glibenclamide",
                            ProductPrice = 10f
                        },
                        new
                        {
                            ProductId = 23,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = " Reduce glucose reabsorption in the kidneys, leading to increased glucose excretion in the urine.",
                            ProductName = "Canagliflozin",
                            ProductPrice = 10f
                        },
                        new
                        {
                            ProductId = 24,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "to improve urine flow and reduce symptoms associated with BPH.",
                            ProductName = "Flomax",
                            ProductPrice = 15f
                        },
                        new
                        {
                            ProductId = 25,
                            CategoryId = 4,
                            ProductCategory = "medicine(with prescriptions)",
                            ProductDescription = "for severe pain due to kidney stone",
                            ProductName = "Oxycodone",
                            ProductPrice = 15f
                        });
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Promotion", b =>
                {
                    b.Property<int>("PromotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromotionId"));

                    b.Property<float?>("PromotionAmount")
                        .HasColumnType("real");

                    b.Property<string>("PromotionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PromotionId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Customer", b =>
                {
                    b.HasOne("CrystalMeds.Shared.Domain.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Order", b =>
                {
                    b.HasOne("CrystalMeds.Shared.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Payment", b =>
                {
                    b.HasOne("CrystalMeds.Shared.Domain.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Prescription", b =>
                {
                    b.HasOne("CrystalMeds.Shared.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Product", b =>
                {
                    b.HasOne("CrystalMeds.Shared.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CrystalMeds.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CrystalMeds.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrystalMeds.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CrystalMeds.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CrystalMeds.Shared.Domain.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
