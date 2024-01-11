﻿// <auto-generated />
using System;
using CombineSample.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CombineSample.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230505041624_yourmigration5")]
    partial class yourmigration5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CombineSample.Models.AddEmployee", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeeId"));

                    b.Property<string>("EmployeeMartialStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeAge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeDOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employmentStartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employmentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employeeId");

                    b.ToTable("AddEmployee_Details");
                });

            modelBuilder.Entity("CombineSample.Models.Employee", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeeId"));

                    b.Property<string>("EmployeeMartialStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PasswordResetTokenExpiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PasswordResetTokenExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("employeeAge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeDOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("employeeImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("employeeLeave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeLeaveEndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeLeaveStartTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeePassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeProject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeWorkingStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employmentStartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employmentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("leaveReason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employeeId");

                    b.ToTable("Employee_Details");
                });

            modelBuilder.Entity("CombineSample.Models.Manager", b =>
                {
                    b.Property<int>("managerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("managerId"));

                    b.Property<string>("managerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("managerImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("managerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("managerNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("managerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("managerId");

                    b.ToTable("Manager_Details");
                });
#pragma warning restore 612, 618
        }
    }
}
