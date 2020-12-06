﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rol.Api.Data;

namespace Rol.Api.Migrations
{
    [DbContext(typeof(RolDbContext))]
    partial class RolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Rol.Api.Data.Entities.Congregation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Principal")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Congregations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Algum lugar",
                            Name = "Matriz",
                            Principal = true
                        },
                        new
                        {
                            Id = 2,
                            Address = "Algum outro lugar",
                            Name = "Outro",
                            Principal = true
                        });
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.CongregationContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CongregationId")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.Property<bool>("Principal")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CongregationId");

                    b.ToTable("CongregationContacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CongregationId = 1,
                            Contact = "77777777",
                            ContactType = 0,
                            Principal = true
                        },
                        new
                        {
                            Id = 2,
                            CongregationId = 2,
                            Contact = "88888888",
                            ContactType = 0,
                            Principal = true
                        });
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BaptismDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CongregationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CongregationId");

                    b.HasIndex("RoleId");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Lugar nenhum",
                            BaptismDate = new DateTime(2020, 12, 5, 18, 54, 20, 519, DateTimeKind.Local).AddTicks(5101),
                            BirthDate = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CongregationId = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "João Ninguém",
                            RegistrationNumber = "11111111",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Lugar outro nenhum",
                            BaptismDate = new DateTime(2020, 12, 5, 18, 54, 20, 526, DateTimeKind.Local).AddTicks(1349),
                            BirthDate = new DateTime(2002, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CongregationId = 2,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModificationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Maria Ninguém",
                            RegistrationNumber = "22222222",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.MemberContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<bool>("Principal")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberContacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Contact = "55555555",
                            ContactType = 0,
                            MemberId = 1,
                            Principal = true
                        },
                        new
                        {
                            Id = 2,
                            Contact = "44444444",
                            ContactType = 0,
                            MemberId = 2,
                            Principal = true
                        });
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pastor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Obreiro"
                        });
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.CongregationContact", b =>
                {
                    b.HasOne("Rol.Api.Data.Entities.Congregation", "Congregation")
                        .WithMany("CongragationContacts")
                        .HasForeignKey("CongregationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Congregation");
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.Member", b =>
                {
                    b.HasOne("Rol.Api.Data.Entities.Congregation", "Congregation")
                        .WithMany("Members")
                        .HasForeignKey("CongregationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rol.Api.Data.Entities.Role", "Role")
                        .WithMany("Members")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Congregation");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.MemberContact", b =>
                {
                    b.HasOne("Rol.Api.Data.Entities.Member", "Member")
                        .WithMany("Contacts")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.Congregation", b =>
                {
                    b.Navigation("CongragationContacts");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.Member", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("Rol.Api.Data.Entities.Role", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}