﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Models;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.Models.Certificate", b =>
                {
                    b.Property<int>("CertificateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificateID"), 1L, 1);

                    b.Property<string>("CertificateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CertificateRank")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CertificatedDate")
                        .HasColumnType("Datetime");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeID1")
                        .HasColumnType("int");

                    b.HasKey("CertificateID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("EmployeeID1");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("_1.DAL.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("Datetime");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Employee_count")
                        .HasColumnType("int");

                    b.Property<int>("Employee_type")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Employee", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");
                });

            modelBuilder.Entity("_1.DAL.Models.Experience", b =>
                {
                    b.HasBaseType("_1.DAL.Models.Employee");

                    b.Property<int>("ExpInYear")
                        .HasColumnType("int");

                    b.Property<string>("ProSkill")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("Experience");
                });

            modelBuilder.Entity("_1.DAL.Models.Fresher", b =>
                {
                    b.HasBaseType("_1.DAL.Models.Employee");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Graduation_date")
                        .HasColumnType("Datetime");

                    b.Property<string>("Graduation_rank")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("Fresher");
                });

            modelBuilder.Entity("_1.DAL.Models.Intern", b =>
                {
                    b.HasBaseType("_1.DAL.Models.Employee");

                    b.Property<string>("Majors")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("University_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("Intern");
                });

            modelBuilder.Entity("_1.DAL.Models.Certificate", b =>
                {
                    b.HasOne("_1.DAL.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.Employee", null)
                        .WithMany("Certificate")
                        .HasForeignKey("EmployeeID1");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("_1.DAL.Models.Employee", b =>
                {
                    b.Navigation("Certificate");
                });
#pragma warning restore 612, 618
        }
    }
}
