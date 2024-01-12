﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shopflow.repository.Contexts;

#nullable disable

namespace shopflow.repository.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20240112232153_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReferencePoint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.Contact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ContactTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContactTypeId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.ContactType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("InternalProperty")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ContactTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "Celular",
                            NormalizedName = "celular",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2690)
                        },
                        new
                        {
                            Id = 2L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "E-mail",
                            NormalizedName = "e",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2700)
                        },
                        new
                        {
                            Id = 3L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "Telegram",
                            NormalizedName = "telegram",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2700)
                        });
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.Document", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DocumentTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Filename")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DocumentTypeId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.DocumentType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("InternalProperty")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "RG",
                            NormalizedName = "rg",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2450)
                        },
                        new
                        {
                            Id = 2L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "CPF",
                            NormalizedName = "cpf",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2580)
                        },
                        new
                        {
                            Id = 3L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "CNPJ",
                            NormalizedName = "cnpj",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2590)
                        },
                        new
                        {
                            Id = 4L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "CNH",
                            NormalizedName = "cnh",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2590)
                        },
                        new
                        {
                            Id = 5L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "Certidão de Nascimento",
                            NormalizedName = "certidão de nascimento",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2600)
                        },
                        new
                        {
                            Id = 6L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "Certidão de Casamento",
                            NormalizedName = "certidão de casamento",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2610)
                        },
                        new
                        {
                            Id = 7L,
                            InternalProperty = true,
                            IsActive = true,
                            Name = "Foto do usuário",
                            NormalizedName = "foto do usuário",
                            Timestamp = new DateTime(2024, 1, 12, 23, 21, 53, 240, DateTimeKind.Utc).AddTicks(2610)
                        });
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.Address", b =>
                {
                    b.HasOne("shopflow.contract.Model.Entities.Customer.Customer", null)
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.Contact", b =>
                {
                    b.HasOne("shopflow.contract.Model.Entities.Customer.ContactType", "ContactType")
                        .WithMany()
                        .HasForeignKey("ContactTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shopflow.contract.Model.Entities.Customer.Customer", null)
                        .WithMany("Contacts")
                        .HasForeignKey("CustomerId");

                    b.Navigation("ContactType");
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.Document", b =>
                {
                    b.HasOne("shopflow.contract.Model.Entities.Customer.Customer", null)
                        .WithMany("Documents")
                        .HasForeignKey("CustomerId");

                    b.HasOne("shopflow.contract.Model.Entities.Customer.DocumentType", "DocumentType")
                        .WithMany()
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentType");
                });

            modelBuilder.Entity("shopflow.contract.Model.Entities.Customer.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Contacts");

                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}