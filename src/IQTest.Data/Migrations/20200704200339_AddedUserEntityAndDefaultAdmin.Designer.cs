﻿// <auto-generated />
using System;
using IQTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IQTest.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200704200339_AddedUserEntityAndDefaultAdmin")]
    partial class AddedUserEntityAndDefaultAdmin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IQTest.Core.Entities.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAnswer")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("IQTest.Core.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("IQTest.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailAddress = "admin@iqtest.com",
                            PasswordHash = new byte[] { 62, 192, 181, 24, 59, 191, 161, 174, 66, 53, 59, 125, 95, 149, 151, 0, 34, 250, 144, 112, 90, 251, 111, 174, 143, 10, 144, 7, 138, 100, 39, 192, 194, 155, 126, 32, 174, 196, 164, 69, 112, 70, 70, 251, 231, 235, 101, 174, 172, 158, 39, 19, 120, 66, 162, 117, 26, 96, 193, 35, 25, 178, 85, 152 },
                            PasswordSalt = new byte[] { 54, 90, 98, 108, 50, 118, 67, 80, 119, 51, 114, 79, 51, 54, 89, 73, 51, 121, 49, 106, 106, 68, 75, 106, 107, 89, 48, 48, 53, 89, 88, 107, 85, 53, 106, 100, 106, 114, 110, 53, 117, 107, 53, 50, 79, 48, 73, 115, 118, 74, 118, 65, 49, 65, 100, 53, 70, 65, 103, 57, 48, 85, 72, 110, 108, 74, 80, 120, 67, 97, 112, 55, 107, 106, 49, 78, 116, 113, 72, 69, 48, 84, 98, 80, 55, 101, 110, 105, 103, 78, 99, 105, 81, 78, 69, 106, 66, 48, 65, 72, 110, 68, 83, 51, 68, 66, 50, 119, 110, 106, 56, 54, 84, 83, 68, 67, 82, 101, 99, 55, 48, 54, 119, 116, 103, 66, 81, 70 },
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("IQTest.Core.Entities.Option", b =>
                {
                    b.HasOne("IQTest.Core.Entities.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
