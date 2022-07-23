﻿// <auto-generated />
using System;
using JobBoardStep.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobBoardStep.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220723062736_InitalCreated")]
    partial class InitalCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JobBoardStep.Data.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("ApplicationStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ApplicationId");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CareateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("ExperienceStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.ExperienceTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("LanguageId");

                    b.ToTable("ExperienceTranslates");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("InformationStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Information");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.InformationTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InformationId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("InformationId");

                    b.HasIndex("LanguageId");

                    b.ToTable("InformationTranslates");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CareateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("JobCateId")
                        .HasColumnType("int");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("JobTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Salary")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("JobId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("JobCategoryId");

                    b.HasIndex("JobTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.JobCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("JobCatName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("JobCategories");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.JobCategoryTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("JobCatId")
                        .HasColumnType("int");

                    b.Property<string>("JobCatName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobCatId");

                    b.HasIndex("LanguageId");

                    b.ToTable("JobCategoryTranslates");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.JobType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CareateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("JobTypeStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("JobTypes");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.JobTypeTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("JobTypeId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("JobTypeId");

                    b.HasIndex("LanguageId");

                    b.ToTable("JobTypeTranslates");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LanguageStatus")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("RegionStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.RegionTranslate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("RegionId");

                    b.ToTable("RegionTranslates");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("InformationId")
                        .HasColumnType("int");

                    b.Property<int>("InformationTranslateId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("RegionTranslateId")
                        .HasColumnType("int");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("InformationId");

                    b.HasIndex("InformationTranslateId");

                    b.HasIndex("RegionId");

                    b.HasIndex("RegionTranslateId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserTypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserTypeId");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Application", b =>
                {
                    b.HasOne("JobBoardStep.Data.Models.Job", "Job")
                        .WithMany("Application")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.User", "Users")
                        .WithMany("Applications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.ExperienceTranslate", b =>
                {
                    b.HasOne("JobBoardStep.Data.Models.Experience", "Experience")
                        .WithMany("ExperienceTranslates")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.Language", "Language")
                        .WithMany("ExperienceTranslates")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Experience");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.InformationTranslate", b =>
                {
                    b.HasOne("JobBoardStep.Data.Models.Information", "Information")
                        .WithMany("InformationTranslates")
                        .HasForeignKey("InformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.Language", "Language")
                        .WithMany("InformationTranslates")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Information");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Job", b =>
                {
                    b.HasOne("JobBoardStep.Data.Models.Experience", "Experience")
                        .WithMany("Jobs")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.JobCategory", "JobCategory")
                        .WithMany("Jobs")
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.JobType", "JobType")
                        .WithMany("Jobs")
                        .HasForeignKey("JobTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.User", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Experience");

                    b.Navigation("JobCategory");

                    b.Navigation("JobType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.JobCategoryTranslate", b =>
                {
                    b.HasOne("JobBoardStep.Data.Models.JobCategory", "JobCategory")
                        .WithMany("JobCategoryTranslates")
                        .HasForeignKey("JobCatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.Language", "Language")
                        .WithMany("JobCategoryTranslates")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobCategory");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.JobTypeTranslate", b =>
                {
                    b.HasOne("JobBoardStep.Data.Models.JobType", "JobType")
                        .WithMany("JobTypeTranslates")
                        .HasForeignKey("JobTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.Language", "Language")
                        .WithMany("JobTypeTranslates")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobType");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.RegionTranslate", b =>
                {
                    b.HasOne("JobBoardStep.Data.Models.Language", "Language")
                        .WithMany("RegionTranslates")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.Region", "Region")
                        .WithMany("RegionTranslates")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.User", b =>
                {
                    b.HasOne("JobBoardStep.Data.Models.Information", "Information")
                        .WithMany("Users")
                        .HasForeignKey("InformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.InformationTranslate", "InformationTranslate")
                        .WithMany("Users")
                        .HasForeignKey("InformationTranslateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.Region", "Region")
                        .WithMany("Users")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.RegionTranslate", "RegionTranslate")
                        .WithMany("Users")
                        .HasForeignKey("RegionTranslateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobBoardStep.Data.Models.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Information");

                    b.Navigation("InformationTranslate");

                    b.Navigation("Region");

                    b.Navigation("RegionTranslate");

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Experience", b =>
                {
                    b.Navigation("ExperienceTranslates");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Information", b =>
                {
                    b.Navigation("InformationTranslates");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.InformationTranslate", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Job", b =>
                {
                    b.Navigation("Application");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.JobCategory", b =>
                {
                    b.Navigation("JobCategoryTranslates");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.JobType", b =>
                {
                    b.Navigation("JobTypeTranslates");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Language", b =>
                {
                    b.Navigation("ExperienceTranslates");

                    b.Navigation("InformationTranslates");

                    b.Navigation("JobCategoryTranslates");

                    b.Navigation("JobTypeTranslates");

                    b.Navigation("RegionTranslates");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.Region", b =>
                {
                    b.Navigation("RegionTranslates");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.RegionTranslate", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("JobBoardStep.Data.Models.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
