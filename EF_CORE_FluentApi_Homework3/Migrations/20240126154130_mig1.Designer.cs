﻿// <auto-generated />
using System;
using EF_CORE_FluentApi_Homework3.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_CORE_FluentApi_Homework3.Migrations
{
    [DbContext(typeof(LibraryDBContext))]
    [Migration("20240126154130_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValue("cox qeseng kitabdir");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("PresId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("ThemeId")
                        .HasColumnType("int");

                    b.Property<int>("YearPress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name");

                    b.HasIndex("PresId");

                    b.HasIndex("ThemeId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Lib", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Libs");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Pres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Press");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.S_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime");

                    b.Property<int>("LibId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LibId");

                    b.HasIndex("StudentId");

                    b.ToTable("SCards");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Term")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.T_Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime");

                    b.Property<int>("LibId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LibId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TCards");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Book", b =>
                {
                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Pres", "Pres")
                        .WithMany("Books")
                        .HasForeignKey("PresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Theme", "Theme")
                        .WithMany("Books")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Pres");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Group", b =>
                {
                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.S_Card", b =>
                {
                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Book", "Book")
                        .WithMany("S_Cards")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Lib", "Lib")
                        .WithMany("S_Cards")
                        .HasForeignKey("LibId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Student", "Student")
                        .WithMany("S_Cards")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Student", b =>
                {
                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.T_Card", b =>
                {
                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Book", "Book")
                        .WithMany("T_Cards")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Lib", "Lib")
                        .WithMany("T_Cards")
                        .HasForeignKey("LibId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Teacher", "Teacher")
                        .WithMany("T_Cards")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Lib");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Teacher", b =>
                {
                    b.HasOne("EF_CORE_FluentApi_Homework3.Entities.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Book", b =>
                {
                    b.Navigation("S_Cards");

                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Faculty", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Lib", b =>
                {
                    b.Navigation("S_Cards");

                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Pres", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Student", b =>
                {
                    b.Navigation("S_Cards");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Teacher", b =>
                {
                    b.Navigation("T_Cards");
                });

            modelBuilder.Entity("EF_CORE_FluentApi_Homework3.Entities.Theme", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
