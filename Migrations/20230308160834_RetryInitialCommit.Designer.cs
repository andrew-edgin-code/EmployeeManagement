﻿// <auto-generated />
using System;
using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230308160834_RetryInitialCommit")]
    partial class RetryInitialCommit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.Models.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.EmployeeEmergencyContact", b =>
                {
                    b.Property<int>("EmployeeEmergencyContactID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Relationship")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeEmergencyContactID", "EmployeeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("EmployeeEmergencyContacts");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.EmployeePosition", b =>
                {
                    b.Property<int>("EmployeePositionID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("EmployeePositionID", "EmployeeID", "PositionID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("PositionID");

                    b.ToTable("EmployeePositions");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.EmployeePositionRate", b =>
                {
                    b.Property<int>("EmployeePositionRateID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeePositionID")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeePositionRateID", "EmployeePositionID");

                    b.HasIndex("EmployeePositionID");

                    b.ToTable("EmployeePositionRates");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionID"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.EmployeeEmergencyContact", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Entities.Employee", "Employee")
                        .WithMany("EmployeeEmergencyContacts")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.EmployeePosition", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Entities.Employee", "Employee")
                        .WithMany("EmployeePositions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EmployeeManagement.Models.Entities.Position", "Position")
                        .WithMany("EmployeePositions")
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.EmployeePositionRate", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Entities.EmployeePosition", "EmployeePosition")
                        .WithMany("EmployeePositionRates")
                        .HasForeignKey("EmployeePositionID")
                        .HasPrincipalKey("EmployeePositionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EmployeePosition");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeEmergencyContacts");

                    b.Navigation("EmployeePositions");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.EmployeePosition", b =>
                {
                    b.Navigation("EmployeePositionRates");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Entities.Position", b =>
                {
                    b.Navigation("EmployeePositions");
                });
#pragma warning restore 612, 618
        }
    }
}
