using JobBoardStep.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JobBoardStep.Data.Context
{
    public class AppDbContext:DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public AppDbContext(DbContextOptions<AppDbContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {

        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Models.Application> Applications { get; set; }
        public DbSet<ExperienceTranslate> ExperienceTranslates { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<InformationTranslate> InformationTranslates { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobCategoryTranslate> JobCategoryTranslates { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<JobTypeTranslate> JobTypeTranslates { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RegionTranslate> RegionTranslates { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

    }
}
