﻿// <auto-generated />
using System;
using BORIS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BORIS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BORIS.Models.ContactViewModel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PreferredSpecialisationID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PreferredSpecialisationID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BORIS.Models.Specialisation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Specialisation");
                });

            modelBuilder.Entity("BORIS.Models.ContactViewModel", b =>
                {
                    b.HasOne("BORIS.Models.Specialisation", "PreferredSpecialisation")
                        .WithMany()
                        .HasForeignKey("PreferredSpecialisationID");

                    b.Navigation("PreferredSpecialisation");
                });
#pragma warning restore 612, 618
        }
    }
}
