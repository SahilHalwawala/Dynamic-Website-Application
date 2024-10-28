﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentGradesApplication.Entities;

#nullable disable

namespace StudentGradesApplication.Migrations
{
    [DbContext(typeof(StudentGradesDbContext))]
    partial class StudentGradesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentGradesApplication.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Name = "English"
                        },
                        new
                        {
                            CourseId = 2,
                            Name = "Math"
                        });
                });

            modelBuilder.Entity("StudentGradesApplication.Entities.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<int?>("CourseId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaxScore")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Score")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("GradeId");

                    b.HasIndex("CourseId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            GradeId = 1,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxScore = 100,
                            Score = 70
                        },
                        new
                        {
                            GradeId = 2,
                            CourseId = 2,
                            Date = new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxScore = 100,
                            Score = 75
                        },
                        new
                        {
                            GradeId = 3,
                            CourseId = 1,
                            Date = new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxScore = 100,
                            Score = 90
                        });
                });

            modelBuilder.Entity("StudentGradesApplication.Entities.Grade", b =>
                {
                    b.HasOne("StudentGradesApplication.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });
#pragma warning restore 612, 618
        }
    }
}
