using JobBoardStep.Data.Context;
using JobBoardStep.Data.Models;
using JobBoardStep.Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoardStep.Data.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Job job)
        {
            await _context.Jobs.AddAsync(job);
           await _context.SaveChangesAsync();   
        }

        public async Task DeleteAsync(int id)
        {
            var result = await GetByIdAsync(id);
             _context.Jobs.Remove(result);
            await _context.SaveChangesAsync();
        }

        

        public Task<IEnumerable<Experience>> GetAllExperiences()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JobType>> GetAllJobType()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<Job> GetByIdAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Jobs.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public Task<Experience> GetByIdExperience(int id)
        {
            throw new NotImplementedException();
        }

        public Task<JobType> GetByIdJobType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<JobCategory> GetByIdUserCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Job job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();  
        }

       public async Task<IEnumerable<JobIndexViewModel>> GetAllAsync()
        {
            var data =   _context.Jobs.Select(x => new JobIndexViewModel
            {
                Salary = x.Salary,
                CareateDate = x.CareateDate,
                UpdateDate = x.UpdateDate,  
                Description = x.Description,    
                //JobTypeId = x.JobTypeId,
                //ExperienceId = x.ExperienceId,
                //UserId = x.UserId,
                //JobCateId = x.JobCateId
               
            });
            return  data;
        }
    }
}
