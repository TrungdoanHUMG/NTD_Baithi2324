﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NTDBaithi2324.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240617062824_Creat_table_Person")]
    partial class CreattablePerson
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("NTD_Baithi2324.Models.NTD195Person", b =>
                {
                    b.Property<string>("NTD195PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("NTD195Diachi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NTD195FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NTD195PersonID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("NTD_Baithi2324.Models.NTD195Student", b =>
                {
                    b.Property<string>("NTD195StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("NTD195FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NTD195MaLOP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NTD195StudentID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}