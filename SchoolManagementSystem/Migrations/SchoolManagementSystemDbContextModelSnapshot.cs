﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagementSystem.Data;

#nullable disable

namespace SchoolManagementSystem.Migrations
{
    [DbContext(typeof(SchoolManagementSystemDbContext))]
    partial class SchoolManagementSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolManagementSystem.Models.Classs", b =>
                {
                    b.Property<int>("ClasssId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClasssId"), 1L, 1);

                    b.Property<string>("ClasssName")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("ClasssId");

                    b.ToTable("Classses");

                    b.HasData(
                        new
                        {
                            ClasssId = 1,
                            ClasssName = "A"
                        },
                        new
                        {
                            ClasssId = 2,
                            ClasssName = "B"
                        },
                        new
                        {
                            ClasssId = 3,
                            ClasssName = "C"
                        },
                        new
                        {
                            ClasssId = 4,
                            ClasssName = "D"
                        },
                        new
                        {
                            ClasssId = 5,
                            ClasssName = "E"
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"), 1L, 1);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            GenderName = "Male"
                        },
                        new
                        {
                            GenderId = 2,
                            GenderName = "Female"
                        },
                        new
                        {
                            GenderId = 3,
                            GenderName = "Couldn't find"
                        },
                        new
                        {
                            GenderId = 19,
                            GenderName = "Agender"
                        },
                        new
                        {
                            GenderId = 4,
                            GenderName = "Transsexual"
                        },
                        new
                        {
                            GenderId = 5,
                            GenderName = "Intersex"
                        },
                        new
                        {
                            GenderId = 6,
                            GenderName = "Non-Conforming"
                        },
                        new
                        {
                            GenderId = 7,
                            GenderName = "Bigender"
                        },
                        new
                        {
                            GenderId = 8,
                            GenderName = "Butch"
                        },
                        new
                        {
                            GenderId = 9,
                            GenderName = "Cisgender"
                        },
                        new
                        {
                            GenderId = 10,
                            GenderName = "Gender expansive"
                        },
                        new
                        {
                            GenderId = 11,
                            GenderName = "Genderfluid"
                        },
                        new
                        {
                            GenderId = 12,
                            GenderName = "Gender Outlaw"
                        },
                        new
                        {
                            GenderId = 13,
                            GenderName = "Genderqueer"
                        },
                        new
                        {
                            GenderId = 14,
                            GenderName = "Masculine of center"
                        },
                        new
                        {
                            GenderId = 15,
                            GenderName = "Nonbinary"
                        },
                        new
                        {
                            GenderId = 16,
                            GenderName = "Omnigender"
                        },
                        new
                        {
                            GenderId = 17,
                            GenderName = "Polygender"
                        },
                        new
                        {
                            GenderId = 18,
                            GenderName = "Two Spirit"
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Markk", b =>
                {
                    b.Property<int>("MarkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarkID"), 1L, 1);

                    b.Property<DateTime>("AddedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emaill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HumanId")
                        .HasColumnType("int");

                    b.HasKey("MarkID");

                    b.ToTable("Markks");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Parentt", b =>
                {
                    b.Property<int>("HumanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HumanId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstandSecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("HumanId");

                    b.HasIndex("StudentId");

                    b.ToTable("Parentt");

                    b.HasData(
                        new
                        {
                            HumanId = 1,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1964, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Luna",
                            GenderId = 1,
                            Lastname = "Deanna1",
                            StudentId = 1
                        },
                        new
                        {
                            HumanId = 2,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1960, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Huna",
                            GenderId = 2,
                            Lastname = "Deanna2",
                            StudentId = 2
                        },
                        new
                        {
                            HumanId = 3,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1964, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Beina",
                            GenderId = 2,
                            Lastname = "Deanna3",
                            StudentId = 3
                        },
                        new
                        {
                            HumanId = 4,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1966, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Layna",
                            GenderId = 2,
                            Lastname = "Deanna4",
                            StudentId = 4
                        },
                        new
                        {
                            HumanId = 5,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1968, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Abuen",
                            GenderId = 1,
                            Lastname = "Deanna5",
                            StudentId = 5
                        },
                        new
                        {
                            HumanId = 6,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1970, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Linu",
                            GenderId = 1,
                            Lastname = "Deanna6",
                            StudentId = 6
                        },
                        new
                        {
                            HumanId = 7,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1971, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Ohan",
                            GenderId = 2,
                            Lastname = "Deanna7",
                            StudentId = 7
                        },
                        new
                        {
                            HumanId = 8,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1959, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Michele",
                            GenderId = 2,
                            Lastname = "Deanna8",
                            StudentId = 8
                        },
                        new
                        {
                            HumanId = 9,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1957, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Larn",
                            GenderId = 1,
                            Lastname = "Deanna9",
                            StudentId = 9
                        },
                        new
                        {
                            HumanId = 10,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1980, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Cubert",
                            GenderId = 1,
                            Lastname = "Deanna10",
                            StudentId = 10
                        },
                        new
                        {
                            HumanId = 11,
                            Address = "Deneme sokağı 14",
                            DOB = new DateTime(1978, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstandSecondName = "Augna Ignis",
                            GenderId = 1,
                            Lastname = "Deanna11",
                            StudentId = 11
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Rolee", b =>
                {
                    b.Property<byte>("RoleeID")
                        .HasColumnType("tinyint");

                    b.Property<string>("RoleeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RoleeID");

                    b.ToTable("Rolees");

                    b.HasData(
                        new
                        {
                            RoleeID = (byte)1,
                            RoleeName = "Candidate"
                        },
                        new
                        {
                            RoleeID = (byte)2,
                            RoleeName = "Student"
                        },
                        new
                        {
                            RoleeID = (byte)3,
                            RoleeName = "Teacher"
                        },
                        new
                        {
                            RoleeID = (byte)4,
                            RoleeName = "Admin"
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Student", b =>
                {
                    b.Property<int>("HumanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HumanId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ClasssId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstandSecondName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HumanId");

                    b.HasIndex("ClasssId");

                    b.HasIndex("GenderId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            HumanId = 1,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 2,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 2,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 1,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 3,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 4,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 4,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 3,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 5,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 2,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 6,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 5,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 7,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 5,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 8,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 6,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 9,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 9,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 10,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 7,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 11,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 10,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 12,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 8,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        },
                        new
                        {
                            HumanId = 13,
                            Address = "Deneme sokağı 14",
                            ClasssId = 1,
                            DOB = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marysedenna@gmail.com",
                            FirstandSecondName = "Maryse Deanna",
                            GenderId = 5,
                            JoinDate = new DateTime(2016, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Hoedemaeker",
                            Marks = 0,
                            PhoneNumber = "0543-432-12-45"
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Teacher", b =>
                {
                    b.Property<int>("HumanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HumanId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ClasssId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstandSecondName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HumanId");

                    b.HasIndex("ClasssId");

                    b.HasIndex("GenderId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            HumanId = 1,
                            Address = "Some random stree 16",
                            ClasssId = 1,
                            DOB = new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Leilahunclock@gmail.com",
                            FirstandSecondName = "Leila Hun",
                            GenderId = 1,
                            JoinDate = new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Clock",
                            PhoneNumber = "0543-234-12-45"
                        },
                        new
                        {
                            HumanId = 2,
                            Address = "Some random stree 16",
                            ClasssId = 2,
                            DOB = new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Leilahunclock@gmail.com",
                            FirstandSecondName = "Leila Hun",
                            GenderId = 2,
                            JoinDate = new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Clock",
                            PhoneNumber = "0543-234-12-45"
                        },
                        new
                        {
                            HumanId = 3,
                            Address = "Some random stree 16",
                            ClasssId = 3,
                            DOB = new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Leilahunclock@gmail.com",
                            FirstandSecondName = "Leila Hun",
                            GenderId = 1,
                            JoinDate = new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Clock",
                            PhoneNumber = "0543-234-12-45"
                        },
                        new
                        {
                            HumanId = 4,
                            Address = "Some random stree 16",
                            ClasssId = 4,
                            DOB = new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Leilahunclock@gmail.com",
                            FirstandSecondName = "Leila Hun",
                            GenderId = 2,
                            JoinDate = new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Clock",
                            PhoneNumber = "0543-234-12-45"
                        },
                        new
                        {
                            HumanId = 5,
                            Address = "Some random stree 16",
                            ClasssId = 2,
                            DOB = new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Leilahunclock@gmail.com",
                            FirstandSecondName = "Leila Hun",
                            GenderId = 1,
                            JoinDate = new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Clock",
                            PhoneNumber = "0543-234-12-45"
                        },
                        new
                        {
                            HumanId = 6,
                            Address = "Some random stree 16",
                            ClasssId = 2,
                            DOB = new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Leilahunclock@gmail.com",
                            FirstandSecondName = "Leila Hun",
                            GenderId = 2,
                            JoinDate = new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Clock",
                            PhoneNumber = "0543-234-12-45"
                        },
                        new
                        {
                            HumanId = 7,
                            Address = "Some random stree 16",
                            ClasssId = 5,
                            DOB = new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Leilahunclock@gmail.com",
                            FirstandSecondName = "Leila Hun",
                            GenderId = 1,
                            JoinDate = new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Clock",
                            PhoneNumber = "0543-234-12-45"
                        },
                        new
                        {
                            HumanId = 8,
                            Address = "Some random stree 16",
                            ClasssId = 5,
                            DOB = new DateTime(1986, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Leilahunclock@gmail.com",
                            FirstandSecondName = "Leila Hun",
                            GenderId = 1,
                            JoinDate = new DateTime(2006, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Lastname = "Clock",
                            PhoneNumber = "0543-234-12-45"
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Userr", b =>
                {
                    b.Property<int>("UserrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserrID"), 1L, 1);

                    b.Property<string>("Emaill")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Passwordd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte>("RoleeID")
                        .HasColumnType("tinyint");

                    b.HasKey("UserrID");

                    b.HasIndex("RoleeID");

                    b.ToTable("Userrs");

                    b.HasData(
                        new
                        {
                            UserrID = 1,
                            Emaill = "candidate@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = (byte)1
                        },
                        new
                        {
                            UserrID = 2,
                            Emaill = "student@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = (byte)2
                        },
                        new
                        {
                            UserrID = 3,
                            Emaill = "teacher@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = (byte)3
                        },
                        new
                        {
                            UserrID = 4,
                            Emaill = "admin@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = (byte)4
                        },
                        new
                        {
                            UserrID = 5,
                            Emaill = "user2@hotmail.com",
                            Passwordd = "123456",
                            RoleeID = (byte)2
                        });
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Parentt", b =>
                {
                    b.HasOne("SchoolManagementSystem.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Student", b =>
                {
                    b.HasOne("SchoolManagementSystem.Models.Classs", "Classs")
                        .WithMany()
                        .HasForeignKey("ClasssId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagementSystem.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classs");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Teacher", b =>
                {
                    b.HasOne("SchoolManagementSystem.Models.Classs", "Classs")
                        .WithMany()
                        .HasForeignKey("ClasssId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolManagementSystem.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classs");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("SchoolManagementSystem.Models.Userr", b =>
                {
                    b.HasOne("SchoolManagementSystem.Models.Rolee", "Rolee")
                        .WithMany()
                        .HasForeignKey("RoleeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rolee");
                });
#pragma warning restore 612, 618
        }
    }
}
